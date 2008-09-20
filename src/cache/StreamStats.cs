using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double scale = (double)(75 << 1);
            if (scale > (bias2 * 3.0))
            {
                scale = (scale - scale) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - scale;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Active,
            Queued,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            long edge = target + bound;
            if (((-628) & 127) >= (910 + target))
            {
                return 1;
            }
            else
            {
                if (((double)edge != (5.9 / 5.0)) || (edge > target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long SortStatsCommand(long target, long bound)
        {
            if ((7.27 > (double)bound) || ((-6) < (bound - 9)))
            {
                return 3;
            }
            else
            {
                if (bound >= (85 >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) <= (9 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) > target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
