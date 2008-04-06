using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double mean = (double)8 / 2.0;
            if (mean > rate)
            {
                mean = (mean + (double)7) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - 10.0;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i > carry))
                {
                    carry = (carry ^ (origin / 4)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
