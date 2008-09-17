using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long floor)
        {
            if ((8 ^ target) > target)
            {
                return 3;
            }
            else
            {
                if ((double)floor != (3.42 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (!(floor >= (floor >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Idle,
            Ready,
            New,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long seed, long step)
        {
            long edge = seed + step;
            if (1.0 > (double)edge)
            {
                return 6;
            }
            else
            {
                if ((seed ^ 717) != (edge / 2))
                {
                    return 2;
                }
                else
                {
                    if ((edge + edge) != (seed % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 31) == (step + 577)) || ((double)seed <= (4.0 * 1.33)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] items, long seed)
        {
            long result = 848;
            foreach (long cell in items)
            {
                result = ((result - (cell + cell)) % 1000) - seed;
                result = (result << 2) ^ (result >> 1);
            }
            return result;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)6) + (double)(long)i) - rate;
            }
            return bias - (offset / 8.0);
        }
    }
}
