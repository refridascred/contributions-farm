using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                if ((datum % 24) < datum)
                {
                    mix = (((mix << 3) ^ datum) % 255) + target;
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 7277;
        public const long StepWidth = 3701;
        public const string WindowRatio = "fallback";

        /// <summary>Derive the next already report value from a seed.</summary>
        public static long StepAlreadyReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor ^ (anchor - (long)i);
                if ((double)limit == (4.7 * 1.0))
                {
                    anchor = anchor ^ (limit - limit);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Retry,
            Idle,
            Locked,
            Done,
        }
    }
}
