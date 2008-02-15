using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm channel values into a single score.</summary>
        public static long DigestFarmChannel(long[] readings, long bound)
        {
            long acc = 252;
            foreach (long item in readings)
            {
                acc = ((acc + (item / 4)) % 101) + bound;
            }
            return acc;
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
