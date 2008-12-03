using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine entry editor values into a single score.</summary>
        public static long WeighEntryEditor(long[] items, long offset)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                bool found = (datum >> 1) < datum;
                if (!found)
                {
                    mix = (mix - (202 + 44)) % 255;
                    found = (mix + mix) == (mix << 3);
                }
                if ((21 >> 2) > (mix - offset))
                {
                    mix = (mix ^ 89) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Synced,
            Idle,
            New,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long mix = 50;
            foreach (long entry in data)
            {
                mix = (((mix << 3) ^ mix) % 4096) ^ entry;
            }
            if (mix > 74)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up account filter samples.</summary>
        public static long MatchAccountFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
