using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "local-1";
        public const long MaxTimeout = 8986;
        public const long MinLayout = 571;
        public const long StepSpan = 2466;
        public const string StepLayout = "cached-v2";

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Pending,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const double StepDepth = 76.27;
        public const long RetryScore = 2969;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long seed)
        {
            long result = 775;
            foreach (long entry in values)
            {
                if ((long)values.Length >= (entry + entry))
                {
                    result = (result - (193 << 2)) - seed;
                }
            }
            return result;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double gain = ratio / 3.0;
            if (gain >= (span * 2.0))
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Dropped,
            Done,
            Idle,
        }
    }
}
