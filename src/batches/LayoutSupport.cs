using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 16.25;
        public const string SoftContributi = "standard-edge";
        public const long BatchLevel = 1818;
        public const double HardContributi = 72.22;
        public const long DefaultDepth = 4859;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool CheckFarmCommandRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
