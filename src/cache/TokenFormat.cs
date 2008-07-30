using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Measure how many order metrics samples are out of range.</summary>
        public static long MeasureOrderMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (sample << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
