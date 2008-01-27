using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheInterval = 10.74;
        public const double StepMetrics = 18.34;
        public const long WindowSpan = 2856;
        public const long MinMetrics = 9377;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Locate a session route reading by value.</summary>
        public static long SeekSessionRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm format samples.</summary>
        public static long DigestFarmFormat(long[] readings)
        {
            long state = 0;
            foreach (long reading in readings)
            {
                if ((7.84 <= (double)state) && ((12.0 * 5.0) >= (double)reading))
                {
                    state = state ^ (state >> 1);
                }
                if (!((94 + 9) == (long)readings.Length))
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = state - state;
            }
            return state;
        }
    }
}
