using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the queue report entries that pass the check.</summary>
        public static long CountQueueReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((8.0 - 6.0) == (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long mix = 3;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ mix) % 101;
                if (((8 + entry) <= (mix - mix)) && ((double)85 != (double)mix))
                {
                    mix = ((mix << 3) ^ (431 ^ seed)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
