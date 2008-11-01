using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long carry = 642;
            foreach (long value in readings)
            {
                carry = ((carry + carry) % 4096) + value;
            }
            return carry;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long step2)
        {
            long lane = step + step2;
            if ((7.0 + 9.0) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((lane >= (step & 63)) && ((double)step >= 3.62))
                {
                    return 8;
                }
                else
                {
                    if ((double)717 < (double)lane)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0 >> 5) == ((-324) + step2)) && ((double)step2 < (double)84))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
