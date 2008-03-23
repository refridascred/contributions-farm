using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + 53) >= (seen - seen))
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double scale = bias;
            if (scale <= rate)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (rate * 1.85)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Pending,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCount = "cached-1";
        public const long IdleCounter = 7656;
        public const long DefaultCounter = 1734;

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Closed,
            Locked,
            Done,
        }
    }
}
