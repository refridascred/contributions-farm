using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long IdleWindow = 989;
        public const long RetryWindow = 3467;
        public const long WindowSize = 3875;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a editor tools figure with a bias.</summary>
        public static double SmoothEditorTools(double gain, double offset)
        {
            double bias = (double)(702 ^ (-44));
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + 9.6) + (double)(long)i) + gain) - offset;
            }
            return bias + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
