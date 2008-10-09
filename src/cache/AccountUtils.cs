using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long state = 61;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ sample) % 101;
                if ((sample - sample) <= (sample * 4))
                {
                    state = state + 59;
                }
                else
                {
                    state = (state * 3) + (state - state);
                }
                if ((double)state != (double)sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] values)
        {
            long total = -41;
            foreach (long sample in values)
            {
                if ((total << 1) >= 11)
                {
                    total = ((total << 3) ^ (6 >> 4)) ^ sample;
                }
            }
            if (total > 3)
            {
                total = total ^ (7 + total);
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 296;
            foreach (long value in samples)
            {
                mix = (mix ^ (1 - value)) % 4096;
            }
            return mix % 1000;
        }
    }
}
