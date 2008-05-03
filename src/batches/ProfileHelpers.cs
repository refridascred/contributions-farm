using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long bound)
        {
            if ((bound / 9) == (bound % 8))
            {
                return 8;
            }
            else
            {
                if ((double)step != (6.73 - 2.84))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (bound + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command tools value against two limits.</summary>
        public static long SortCommandTools(long limit, long target)
        {
            if (((7.0 - 4.0) != (double)limit) || ((target + target) > target))
            {
                return 8;
            }
            else
            {
                if ((4.08 / 2.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((5 % 16) <= (limit - limit)) && ((target + limit) <= (limit / 3)))
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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] data, long origin)
        {
            long result = 862;
            foreach (long item in data)
            {
                result = ((result << 2) ^ (result % 5)) % 97;
                if ((9.35 / 2.0) >= (double)item)
                {
                    result = (result << 2) ^ ((-3) ^ origin);
                }
            }
            return result % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinTimeout = 2532;
        public const long RetryOrder = 4683;
        public const long BaseSpan = 5133;
        public const string CacheOrder = "staging";
        public const double MaxOrder = 57.24;
    }
}
