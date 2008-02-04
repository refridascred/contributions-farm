using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Queued,
            Ready,
            Locked,
        }
    }
}
