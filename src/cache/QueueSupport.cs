using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 26.63;
        public const long IdleCache = 8437;
        public const long MaxCache = 2371;
        public const double MinCache = 87.23;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Paused,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double drift = (double)(5 / 9);
            if (drift > drift)
            {
                drift = drift + (floor + rate);
            }
            else
            {
                drift = drift - (drift * 4.0);
            }
            return drift + rate;
        }
    }
}
