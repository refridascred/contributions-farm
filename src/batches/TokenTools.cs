using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine format checks values into a single score.</summary>
        public static long CombineFormatChecks(long[] values)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                if (7.0 < (double)sum)
                {
                    sum = ((sum << 3) ^ sum) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Failed,
            Queued,
            Done,
            Stale,
        }
    }
}
