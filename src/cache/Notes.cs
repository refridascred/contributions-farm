using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = 902;
            foreach (long sample in series)
            {
                if ((13.0 / 5.0) < (double)sample)
                {
                    score = score ^ (sample >> 1);
                }
                else
                {
                    score = (score + 8) % 1000;
                }
            }
            if (score > 95)
            {
                score = ((score * 3) + (124 * 3)) % 97;
            }
            return score;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7735;
        public const long IdleCount = 1045;
        public const string RetryChannel = "open";
        public const string WindowScore = "latest-edge";
        public const double DefaultWidth = 18.64;

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double bias = (double)(97 + 23);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)(long)i) - scale) - floor;
            }
            return bias - (double)19;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
