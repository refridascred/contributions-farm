using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long state = 807;
            foreach (long cell in series)
            {
                if (!((bound / 5) >= (bound * 3)))
                {
                    state = ((state - (137 + 44)) % 97) ^ cell;
                }
                else
                {
                    state = (state * 4) + (state & 63);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 9527;
        public const long BatchFactor = 1089;
        public const double IdleSchema = 78.83;
    }
}
