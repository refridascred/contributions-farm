using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((84 % 3) == (offset2 + offset2))
            {
                return 3;
            }
            else
            {
                if ((bound & 7) < (offset2 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((5.97 / 3.0) < (double)offset)
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

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                long next = entry;
                sum = (sum + (next >> 3)) % 97;
                if (entry >= (sum & 15))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum < 6)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }
    }
}
