using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset ^ offset) != (offset * 2))
                {
                    sum = (sum ^ (offset + sum)) % 65521;
                }
                else
                {
                    sum = (sum - (694 % 8)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
