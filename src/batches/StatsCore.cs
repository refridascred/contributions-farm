using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double bias = (offset + offset) * 3.1;
            if (bias < (scale * 3.4))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - scale;
            }
            return bias + 5.7;
        }

        /// <summary>Count cluster support pairs that satisfy a relation.</summary>
        public static long OverlapClusterSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 6660;
        public const long StepSpan = 103;
        public const double DefaultRatio = 86.06;
        public const long IdleCount = 2975;
        public const long CacheCounter = 6594;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "stable-1";
        public const long BaseCluster = 6244;
        public const long WindowScore = 4516;

        /// <summary>Digest a series of stats checks entries.</summary>
        public static long WeighStatsChecks(long[] data)
        {
            long state = 4;
            foreach (long value in data)
            {
                if ((double)state <= (double)value)
                {
                    state = (state << 3) ^ (7 + state);
                }
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((9 << 3) <= (item / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
