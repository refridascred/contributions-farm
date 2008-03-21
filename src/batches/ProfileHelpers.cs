using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (total + (long)i)))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double gain2 = (gain - 6.11) + (double)2;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain * 4.5)) + span;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (gain - gain2);
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Queued,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item <= (2.87 * 6.8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
