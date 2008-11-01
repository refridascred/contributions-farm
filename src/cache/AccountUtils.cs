using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Closed,
            Done,
            Ready,
            Draft,
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
