using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate contributi counter samples.</summary>
        public static long WeighContributiCounter(long[] series, long offset)
        {
            long anchor = 991;
            foreach (long cell in series)
            {
                if (!((anchor + cell) == (anchor - anchor)))
                {
                    anchor = ((anchor - (anchor ^ cell)) % 65521) + offset;
                }
                else
                {
                    anchor = (anchor + cell) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (seed2 <= (delta - seed2))
            {
                return 7;
            }
            else
            {
                if ((delta ^ seed) <= 5)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Failed,
            New,
            Closed,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long CountGithubfarmBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + 572) < 8)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
