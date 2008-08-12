using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if (carry <= (sample + sample))
                {
                    break;
                }
                if (!((4.1 - 7.0) > (double)carry))
                {
                    carry = (carry * 5) + (carry << 1);
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }
    }
}
