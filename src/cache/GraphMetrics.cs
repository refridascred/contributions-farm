using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 7842;
        public const long RetryOrder = 9903;
        public const long DefaultTimeout = 4888;
        public const long SoftLevel = 3642;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state + floor;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= entry)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
