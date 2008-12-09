using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "fallback-v2";
        public const string BatchScore = "stable-edge";
        public const string BurstPayload = "open";
        public const string StepPayload = "local-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4280;
        public const long HardTimeout = 9571;
        public const string BaseSpan = "strict";

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long origin)
        {
            long anchor = 928;
            foreach (long reading in levels)
            {
                if (((double)anchor < (0.65 + 3.0)) || ((61 % 24) <= (reading + origin)))
                {
                    anchor = anchor ^ (8 / 8);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
