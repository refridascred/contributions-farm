using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] series, long bound)
        {
            long mix = 62;
            foreach (long cell in series)
            {
                if (((bound + cell) >= (12 << 2)) || ((42 + cell) < (mix + mix)))
                {
                    mix = (mix - (bound ^ mix)) % 255;
                }
            }
            if (mix > 163)
            {
                mix = mix ^ bound;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Active,
            Synced,
            New,
            Retry,
        }

        /// <summary>Scale a record editor figure with a bias.</summary>
        public static double AdjustRecordEditor(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = (ratio - ratio) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (9.66 / 3.0)) - (double)(long)i;
            }
            return ratio - (ratio + offset);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepFactor = 14.26;
        public const long IdleGithubfarm = 7703;
        public const string RetryTimeout = "legacy-edge";
        public const long WindowGithubfarm = 9115;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
