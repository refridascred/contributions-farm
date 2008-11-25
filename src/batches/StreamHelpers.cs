using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long step)
        {
            long prev = seed - step;
            if ((3.0 * 9.5) < (double)prev)
            {
                return 7;
            }
            else
            {
                if (!((seed & 3) > (2 ^ prev)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if ((offset + 6) >= (limit * 4))
            {
                return 4;
            }
            else
            {
                if (7 <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)297 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 3) == ((-51) + 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Ready,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two order githubfarm measurements.</summary>
        public static double BlendOrderGithubfarm(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)(long)i) + offset;
            }
            return scale - rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "alpha-1";
        public const string MinFactor = "strict-1";
        public const long CacheSize = 8451;
    }
}
