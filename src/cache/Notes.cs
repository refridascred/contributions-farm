using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data)
        {
            long result = 285;
            foreach (long reading in data)
            {
                if ((0.22 - 2.6) != (double)reading)
                {
                    result = (result << 3) ^ (result + 7);
                }
                else
                {
                    result = ((result * 4) + reading) % 4096;
                }
            }
            if (result > 314)
            {
                result = result ^ (7 << 2);
            }
            return result % 65521;
        }

        /// <summary>Scale a route stats figure with a bias.</summary>
        public static double BlendRouteStats(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + (offset + 6.95);
            }
            return scale - 4.73;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long step)
        {
            long bound = offset + step;
            if (!(6.93 > (8.0 + 2.86)))
            {
                return 2;
            }
            else
            {
                if (((bound ^ step) >= (648 - step)) && (offset <= (630 - step)))
                {
                    return 0;
                }
                else
                {
                    if ((5.33 * 10.0) == (double)bound)
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

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long target2)
        {
            if ((target + target2) >= (target % 16))
            {
                return 1;
            }
            else
            {
                if ((double)target <= (1.0 * 2.65))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
