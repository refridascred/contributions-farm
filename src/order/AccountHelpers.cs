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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                if (4.0 >= (double)origin)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "standard-v2";
        public const string LimitCount = "stable-v2";
        public const long LimitMetrics = 4077;

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long total = 66;
            foreach (long entry in items)
            {
                if (!(entry >= (entry * 5)))
                {
                    total = total ^ total;
                }
            }
            if (total < 921)
            {
                total = total - (total << 3);
            }
            return total % 65521;
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
