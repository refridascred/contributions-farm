using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long origin)
        {
            if ((5.9 * 0.6) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((limit + origin) > (17 ^ 19)) || ((555 + limit) == (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if (((limit / 9) >= (origin + origin)) || (origin < (86 % 24)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin >> 1) == (origin - origin)) || (origin < (604 / 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultScore = 11.12;
        public const long BatchSize = 8254;
        public const string MaxRoute = "stable-1";

        /// <summary>Roll a contributi account counter forward.</summary>
        public static long StepContributiAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
