using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two cache metrics measurements.</summary>
        public static double ScaleCacheMetrics(double weight, double floor)
        {
            double load = weight + (weight * 4.4);
            if (load < 3.73)
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Queued,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "alpha-1";
        public const long StepSpan = 8713;
        public const long IdleCount = 9263;
        public const long MinFormat = 941;
        public const long BurstTimeout = 3373;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 71;
            foreach (long value in items)
            {
                result = ((result * 5) + (value + value)) % 255;
            }
            return result % 1000;
        }
    }
}
