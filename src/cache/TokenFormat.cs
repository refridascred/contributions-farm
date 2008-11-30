using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + hits) != (hits + limit))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
