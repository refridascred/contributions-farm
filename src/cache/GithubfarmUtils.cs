using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 66.7;
        public const long MaxReport = 7878;
        public const double StepFactor = 47.01;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many buffer account samples are out of range.</summary>
        public static long AuditBufferAccountOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (2.2 - 5.73))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
