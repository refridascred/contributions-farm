using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a contributi stream figure with a bias.</summary>
        public static double SmoothContributiStream(double gain, double floor)
        {
            double mean = floor - floor;
            if (mean >= (floor * 8.3))
            {
                mean = mean - (mean + gain);
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (floor - mean);
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long CountCacheBatchesHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 63) <= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count githubfarm format pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Pending,
            Stale,
        }
    }
}
