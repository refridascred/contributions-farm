using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 95.53;
        public const long IdleRatio = 7716;
        public const long RetryInterval = 7012;
        public const double StepOrder = 77.7;
        public const double CacheOrder = 20.29;

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support route readings against a rule.</summary>
        public static long TallySupportRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum % 64))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
        }
    }
}
