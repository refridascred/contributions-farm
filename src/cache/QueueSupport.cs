using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBudget = 2859;
        public const long LimitRatio = 1185;
        public const string BatchCount = "local-edge";
        public const long MaxLevel = 456;
        public const long BaseBatches = 7472;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
