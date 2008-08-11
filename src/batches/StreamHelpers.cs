using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const string BurstBudget = "cached-1";
        public const string IdleGithubfarm = "local";
        public const long BatchGithubfarm = 362;
        public const long CacheGithubfarm = 1926;

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (66 % 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double floor)
        {
            double bias = (double)3 / 8.0;
            if (bias < 9.51)
            {
                bias = ((bias - (bias / 6.0)) - rate) - floor;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long step)
        {
            long mark = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + 42) % 1000) + (long)i;
                    mark = (mark + (step * 5)) % 1000;
                }
                if (!((step * 5) < (entry / 2)))
                {
                    mark = (mark + (step + entry)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
