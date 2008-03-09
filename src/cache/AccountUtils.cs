using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long origin)
        {
            long gap = limit - origin;
            if (((18.0 + 10.0) < (double)limit) && ((limit & 63) < limit))
            {
                return 5;
            }
            else
            {
                if ((limit ^ 587) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (5.1 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap - gap) < gap)
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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seed > (seed >> 3))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
