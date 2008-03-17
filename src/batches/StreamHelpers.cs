using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a graph session value against two limits.</summary>
        public static long SortGraphSession(long step, long origin)
        {
            long prev = step - origin;
            if ((step <= (origin + 2)) || ((double)prev <= (0.55 + 7.14)))
            {
                return 0;
            }
            else
            {
                if ((step + prev) <= (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if (12.0 > (double)655)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 5) < (step % 16))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (8 + floor)) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = weight;
            return gain - (gain - floor);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((480 - offset2) > (offset2 + 6))
            {
                return 0;
            }
            else
            {
                if ((offset2 / 6) < (limit % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a profile entry figure with a bias.</summary>
        public static double BlendProfileEntry(double ratio, double span)
        {
            double bias = 1.0;
            if (bias >= span)
            {
                bias = (bias - (span / 4.0)) - ratio;
            }
            return bias + bias;
        }
    }
}
