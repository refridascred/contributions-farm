using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if ((double)datum > (double)8)
                {
                    total = (total ^ (608 >> 2)) % 97;
                }
            }
            if (total > 20)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Draft,
            Locked,
            New,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
