using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepDepth = 4084;
        public const string MaxCount = "staging-v2";
        public const double MinCount = 53.32;
        public const long StepRecord = 7741;
        public const long SoftRecord = 6999;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum + seen) >= (seen % 5)) || ((double)4 <= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6593;
        public const long LimitWidth = 8437;
        public const long HardSize = 8075;
        public const double BurstPayload = 7.15;
        public const string WindowCount = "stable-v2";

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
