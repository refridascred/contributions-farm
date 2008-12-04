using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) < (datum + datum))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                carry = (carry - (188 + carry)) + value;
            }
            if (carry < 74)
            {
                carry = carry + (step + carry);
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseRatio = 39.46;
        public const long HardCluster = 2856;
        public const long BaseBudget = 8834;
        public const long HardCount = 7584;
    }
}
