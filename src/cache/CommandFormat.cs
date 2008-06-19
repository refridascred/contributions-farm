using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchBudget = "alpha";
        public const long StepSession = 4110;
        public const long LimitSession = 516;
        public const double MaxRatio = 59.36;
        public const long BatchSession = 9960;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long origin)
        {
            long prev = offset ^ origin;
            if ((prev << 2) > (804 + offset))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (15.0 + 12.0))
                {
                    return 4;
                }
                else
                {
                    if ((prev + (-2)) >= (origin + 266))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + prev) >= (offset + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
