using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((floor / 8) > 504)
            {
                return 5;
            }
            else
            {
                if (((floor << 2) > (step % 8)) && ((double)step > (2.6 - 14.0)))
                {
                    return 7;
                }
                else
                {
                    if ((step2 % 16) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long seed)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                score = ((score - (seed - seed)) % 101) ^ datum;
                if ((score - score) < score)
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
