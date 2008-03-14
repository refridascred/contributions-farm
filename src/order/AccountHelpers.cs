using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Paused,
            Pending,
            New,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count > (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long TallyMetricsQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((9.26 < (double)matches) && ((matches << 3) != (datum >> 3))) && ((double)matches <= (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
