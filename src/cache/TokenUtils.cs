using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long result = 31;
            foreach (long sample in readings)
            {
                result = result + (sample - sample);
                if ((sample > 35) || ((double)result < (double)9))
                {
                    result = result + (sample % 10);
                }
            }
            if (result < 89)
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)(long)i) + scale;
            }
            return load + (double)4;
        }
    }
}
