using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two token filter measurements.</summary>
        public static double SmoothTokenFilter(double rate, double span)
        {
            double ratio = (4.1 / 7.0) / 3.0;
            if (ratio <= 5.0)
            {
                ratio = ratio + rate;
            }
            return ratio + span;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstLevel = 9078;
        public const string IdleInterval = "primary-1";
        public const double IdleWidth = 12.7;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) >= (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Locked,
            Pending,
        }
    }
}
