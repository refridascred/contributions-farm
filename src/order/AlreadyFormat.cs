using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long total = 86;
            foreach (long reading in samples)
            {
                if (reading < (reading & 127))
                {
                    total = total ^ 1;
                }
                if ((reading << 1) >= total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
