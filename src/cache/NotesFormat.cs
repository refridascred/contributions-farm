using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 83.18;
        public const string BaseGithubfarm = "strict-v2";
        public const double LimitCount = 50.16;
        public const double MaxSpan = 19.62;
        public const long SoftGithubfarm = 1323;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples)
        {
            long total = 5;
            foreach (long item in samples)
            {
                if (item > (item ^ 68))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double rate = floor + (scale + floor);
            if (rate >= floor)
            {
                rate = rate - (scale - rate);
            }
            return rate + (double)345;
        }
    }
}
