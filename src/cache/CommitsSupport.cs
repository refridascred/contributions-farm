using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4408;
        public const long IdleWidth = 1422;
        public const long CacheReport = 6415;

        /// <summary>Scale a queue commits figure with a bias.</summary>
        public static double ScaleQueueCommits(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale + rate))
            {
                scale = (scale - 16.0) - offset;
            }
            else
            {
                scale = scale - (rate * 3.6);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 5.0)) - (double)(long)i;
            }
            return scale - (double)774;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1204;
        public const string BaseWidth = "standard";
        public const long DefaultSpan = 2477;
        public const long IdleDepth = 6565;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            New,
            Stale,
            Pending,
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool VerifyRecordMetricLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 3.08;
        public const long DefaultScore = 7075;
        public const long RetryGraph = 1457;
    }
}
