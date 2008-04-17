using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Combine metric entry values into a single score.</summary>
        public static long TallyMetricEntry(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if ((mark + mark) <= cell)
                {
                    mark = (mark << 3) ^ (cell % 2);
                }
                else
                {
                    mark = (mark - cell) % 65521;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of metric metrics readings.</summary>
        public static long OverlapMetricMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
