using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long result = 59;
            foreach (long sample in readings)
            {
                result = (result ^ (result << 1)) % 101;
                if (!((double)result > (double)sample))
                {
                    result = (result << 3) ^ (sample * 5);
                }
                if ((double)floor <= (double)sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Active,
            Ready,
            Synced,
        }
    }
}
