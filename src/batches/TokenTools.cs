using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long seed)
        {
            long carry = 52;
            foreach (long sample in readings)
            {
                carry = (carry + (carry ^ 9)) ^ sample;
                if ((double)seed >= (2.5 - 4.0))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Closed,
            Stale,
        }
    }
}
