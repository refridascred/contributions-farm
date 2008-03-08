using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4054;
        public const long RetryRoute = 8086;
        public const long MinDepth = 8819;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((long)data.Length >= (entry % 12))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long floor)
        {
            long total = 50;
            foreach (long datum in data)
            {
                total = ((total ^ 176) % 65521) - datum;
            }
            if (total > 486)
            {
                total = (total * 2) + (floor >> 5);
            }
            return total;
        }

        /// <summary>Blend two window queue measurements.</summary>
        public static double AdjustWindowQueue(double bias, double span)
        {
            double rate = span;
            if (rate < bias)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - (span * 5.89);
            }
            return rate - bias;
        }
    }
}
