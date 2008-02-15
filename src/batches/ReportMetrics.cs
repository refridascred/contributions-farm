using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                carry = (carry ^ (carry * 4)) + entry;
            }
            if (carry < 49)
            {
                carry = (carry * 3) + (carry & 15);
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 19.06;
        public const double BatchCommand = 62.37;
        public const string MinLevel = "standard-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5138;
        public const string BaseContext = "standard-1";
        public const long MinContext = 1457;
        public const long DefaultContext = 3044;
        public const long MaxDepth = 1107;
    }
}
