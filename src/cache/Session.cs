using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 767;
        public const double HardContributi = 22.62;
        public const string DefaultTimeout = "strict-edge";
        public const long CacheRatio = 5834;
        public const long LimitWidth = 4959;

        /// <summary>Accumulate order batches samples.</summary>
        public static long TotalOrderBatches(long[] readings, long step)
        {
            long sum = 70;
            foreach (long value in readings)
            {
                sum = (((sum * 3) + (902 * 4)) - value) + step;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
