using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long result = 38;
            foreach (long entry in data)
            {
                if (!((result * 2) <= entry))
                {
                    result = result + 26;
                }
                else
                {
                    result = result - (entry ^ result);
                }
            }
            return result;
        }

        /// <summary>Combine queue graph values into a single score.</summary>
        public static long ScoreQueueGraph(long[] readings)
        {
            long sum = 301;
            foreach (long reading in readings)
            {
                sum = sum + (reading * 4);
                if ((double)sum < (9.9 * 15.0))
                {
                    break;
                }
            }
            if (sum < 62)
            {
                sum = (sum - (4 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Pending,
            Synced,
            Dropped,
            Paused,
        }
    }
}
