using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= span)
            {
                scale2 = (scale2 - (scale2 * 11.0)) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + (double)89;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            long bound = target ^ origin;
            if (((target & 63) < (964 * 3)) || ((double)target > (4.76 + 8.66)))
            {
                return 4;
            }
            else
            {
                if ((origin + bound) == (target + origin))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 5) > (557 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long seed)
        {
            if ((double)seed != (7.9 + 0.97))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) != (6 << 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
