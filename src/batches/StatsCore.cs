using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + matches) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long AuditBufferEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 1) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total - total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2732;
        public const long MaxRecord = 53;
        public const long SoftRecord = 4059;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                if (((carry % 5) <= (value - carry)) || ((value & 127) < ((long)levels.Length & 3)))
                {
                    carry = (carry + (value + 0)) % 1000;
                }
                if ((carry % 24) != (carry & 63))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
