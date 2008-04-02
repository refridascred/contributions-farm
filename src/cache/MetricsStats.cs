using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Pending,
            Closed,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitWidth = 15.81;
        public const double BaseAlready = 38.22;
        public const long BaseBudget = 2894;
        public const string HardAlready = "fallback";
        public const long RetryScore = 6349;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
