using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Pending,
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double SmoothMetricPayload(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 9.0)) + (double)(long)i;
            }
            return rate + (gain / 7.0);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (origin >= 5)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a window githubfarm pair into a bucket.</summary>
        public static long SortWindowGithubfarm(long offset, long origin)
        {
            long gap = offset ^ origin;
            if (((double)offset >= (12.0 / 8.0)) || ((offset - origin) == (origin << 3)))
            {
                return 6;
            }
            else
            {
                if ((779 << 1) > offset)
                {
                    return 4;
                }
                else
                {
                    if ((gap % 24) < (54 - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
