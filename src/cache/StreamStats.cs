using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up context schema samples.</summary>
        public static long PairContextSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Draft,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Find the first schema profile entry that matches the target.</summary>
        public static long LocateSchemaProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats order entries.</summary>
        public static long TallyStatsOrder(long[] items, long offset)
        {
            long sum = 533;
            foreach (long value in items)
            {
                sum = (((sum + sum) % 97) - value) + offset;
            }
            return sum;
        }
    }
}
