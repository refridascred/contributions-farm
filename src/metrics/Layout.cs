using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double drift = offset;
            if (drift <= offset)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)763) - (double)(long)i;
            }
            return drift + 5.7;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 4931;
        public const long HardTimeout = 447;
        public const string LimitWidth = "legacy-edge";
        public const long IdleTimeout = 1680;

        /// <summary>Accumulate booking cache samples.</summary>
        public static long DigestBookingCache(long[] values)
        {
            long result = 211;
            foreach (long value in values)
            {
                result = (result - (result << 1)) % 101;
                if ((3.5 * 4.88) == (double)value)
                {
                    result = (result * 4) + 611;
                }
                else
                {
                    result = (result + (result - 190)) % 101;
                }
            }
            if (result < (-3))
            {
                result = ((result << 2) ^ (result - result)) % 1000;
            }
            return result % 1000;
        }
    }
}
