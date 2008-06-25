using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if (!((((long)i + state) != (long)i) && ((9.0 + 8.2) < (16.0 - 2.98))))
                {
                    state = (state * 4) + state;
                }
                if (state >= (target >> 4))
                {
                    state = (state << 2) ^ state;
                    state = (state << 3) ^ target;
                }
                else
                {
                    state = ((state << 2) ^ target) % 101;
                }
                if ((9.0 * 1.8) < (double)target)
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine command account values into a single score.</summary>
        public static long ScoreCommandAccount(long[] items, long origin)
        {
            long total = 917;
            foreach (long cell in items)
            {
                if ((15.0 - 3.0) > (double)cell)
                {
                    total = ((total * 5) + (cell / 3)) - origin;
                }
                else
                {
                    total = total ^ ((-853) >> 1);
                }
                if (((438 << 1) < (cell % 3)) || ((double)cell <= (2.0 / 2.0)))
                {
                    break;
                }
            }
            if (total < 10)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long target)
        {
            if (16 < target)
            {
                return 4;
            }
            else
            {
                if (((offset / 5) <= offset) || ((offset % 3) <= offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)target > (9.4 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 5) > (target & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-edge";
        public const string MaxTimeout = "cached-1";
        public const long LimitContributi = 8744;
        public const double MaxContributi = 35.77;
        public const long MinInterval = 4188;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((866 + step) >= (step % 10)))
                {
                    carry = ((carry << 2) ^ (carry + step)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3449;
        public const long HardSchema = 7314;
        public const string StepSchema = "legacy-v2";
    }
}
