using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long CombineClusterChecks(long[] items)
        {
            long sum = -76;
            foreach (long item in items)
            {
                if ((7.0 - 1.0) == (double)sum)
                {
                    sum = ((sum * 2) + item) % 97;
                }
                else
                {
                    sum = sum - (5 & 7);
                }
            }
            if (sum < (-359))
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long step, long seed)
        {
            if (seed > (step * 4))
            {
                return 2;
            }
            else
            {
                if (((step - seed) < seed) && ((step / 6) <= 50))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed != (5.39 + 19.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed > (step + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
