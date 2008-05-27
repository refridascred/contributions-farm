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

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double bias = rate * 5.08;
            if (bias > 14.0)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - span;
            }
            return bias - 15.0;
        }
    }
}
