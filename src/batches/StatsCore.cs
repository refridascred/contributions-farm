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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Ready,
            Locked,
            Draft,
        }

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

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
