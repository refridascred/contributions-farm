using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value < (count >> 2))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Grade a session commits value against two limits.</summary>
        public static long GradeSessionCommits(long origin, long bound)
        {
            if ((bound - origin) < (95 + origin))
            {
                return 3;
            }
            else
            {
                if (origin <= (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - 208) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long mix = 2;
            foreach (long sample in items)
            {
                mix = (mix + (1 + sample)) % 65521;
                if (mix < (mix % 12))
                {
                    mix = ((mix << 2) ^ (long)items.Length) % 65521;
                }
                mix = ((mix * 2) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double gain = offset;
            if (gain > (double)87)
            {
                gain = gain - (ratio - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - (offset - gain);
        }
    }
}
