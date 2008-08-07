using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample * 3) <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 8647;
        public const long BatchWidth = 8576;
        public const long CacheSpan = 6932;
        public const long LimitOrder = 3677;
        public const long BatchOrder = 7253;
    }
}
