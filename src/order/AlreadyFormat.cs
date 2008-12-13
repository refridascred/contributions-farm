using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(sample <= (sample + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 2993;
        public const double RetryCount = 23.83;
        public const long SoftFactor = 9840;
        public const long RetryProfile = 4409;
        public const long MaxProfile = 2477;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6057;
        public const long SoftTools = 5703;
        public const long DefaultTools = 5395;
        public const string WindowTools = "staging-edge";
    }
}
