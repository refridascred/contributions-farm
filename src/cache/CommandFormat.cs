using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long bound)
        {
            if (bound <= (limit + bound))
            {
                return 7;
            }
            else
            {
                if ((double)limit > (9.6 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) < (9 - 702))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((469 * 2) > (bound * 4)) || ((bound - 89) < (8 + 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (sum % 100)) % 255;
                sum = ((sum * 5) + ((long)i * 5)) % 255;
                sum = (sum << 2) ^ ((-33) & 31);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
