using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long total = 7;
            foreach (long entry in data)
            {
                if (!((total & 1) == (7 & 7)))
                {
                    total = ((((total * 5) + (total & 7)) % 255) ^ entry) - seed;
                }
            }
            if (total < (-419))
            {
                total = total + (total / 3);
            }
            return total;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a payload stream value against two limits.</summary>
        public static long ClassifyPayloadStream(long offset, long limit)
        {
            if ((offset ^ offset) != (limit << 1))
            {
                return 0;
            }
            else
            {
                if (332 >= (limit + offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
