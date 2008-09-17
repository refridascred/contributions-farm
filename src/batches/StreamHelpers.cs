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

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool GuardAlreadySessionBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
