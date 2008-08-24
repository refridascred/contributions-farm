using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (4.0 + 8.1))
                {
                    seen = ((seen + 1) - sample) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const double BaseSpan = 86.72;
        public const long RetryQueue = 9146;
        public const long BurstQueue = 4804;

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ScaleChannelOrder(double gain, double offset)
        {
            double weight = offset;
            if (weight < 0.5)
            {
                weight = weight + 11.0;
            }
            else
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((5.0 < (double)seen) || (item <= (seen - 67))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
