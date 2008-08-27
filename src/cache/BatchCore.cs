using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Dropped,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                }
                if ((686 > bound) || (bound <= score))
                {
                    score = score ^ (bound ^ 8);
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (long)i) % 101;
                }
                score = (score << 2) ^ (bound & 255);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a commits metric reading by value.</summary>
        public static long SeekCommitsMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
