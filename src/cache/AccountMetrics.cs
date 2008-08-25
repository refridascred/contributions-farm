using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseLevel = 9564;
        public const double MaxScore = 96.25;
        public const long LimitWidth = 1905;
        public const long RetryTools = 3945;
        public const long IdleTools = 8835;

        /// <summary>Combine notes counter values into a single score.</summary>
        public static long TotalNotesCounter(long[] readings, long seed)
        {
            long sum = 429;
            foreach (long entry in readings)
            {
                if (!((entry + (long)readings.Length) >= (entry % 100)))
                {
                    sum = sum + 4;
                }
                if (((sum + sum) == (entry / 9)) || ((double)seed <= (17.0 / 2.0)))
                {
                    sum = sum - (89 - sum);
                }
                else
                {
                    sum = (sum ^ (sum / 3)) % 65521;
                }
                if ((sum ^ entry) <= (seed >> 4))
                {
                    break;
                }
            }
            if (sum < 15)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback";
        public const double BaseScore = 52.11;
        public const long SoftCount = 5119;
        public const string StepDepth = "cached-1";
        public const long WindowScore = 5665;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
