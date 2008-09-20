using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a tools session counter forward.</summary>
        public static long SeriesToolsSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 94.77;
        public const double BurstScore = 68.23;
        public const long StepInterval = 1212;
        public const long RetryCount = 947;
        public const long WindowGithubfarm = 2537;

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (1.0 * 9.7))
            {
                bias2 = (bias2 - (floor + floor)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (3.0 / 7.0)) + (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 829;
            foreach (long datum in series)
            {
                if ((carry / 2) > (datum - datum))
                {
                    carry = carry ^ (carry + datum);
                }
                else
                {
                    carry = ((carry << 2) ^ datum) % 101;
                }
            }
            return carry;
        }
    }
}
