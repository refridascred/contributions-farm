using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4528;
        public const double BurstStats = 12.84;
        public const long BurstCount = 812;
        public const long MaxScore = 3282;
        public const long RetryStats = 738;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long bound2)
        {
            long span = bound + bound2;
            if (((bound >> 4) <= bound) && (span >= (span - 132)))
            {
                return 8;
            }
            else
            {
                if ((span + bound) >= (8 + bound))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two counter batches measurements.</summary>
        public static double AdjustCounterBatches(double weight, double offset)
        {
            double drift = 2.1 + (weight / 8.0);
            if (drift > (double)57)
            {
                drift = drift + (weight * 1.0);
            }
            else
            {
                drift = drift + (double)659;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (offset - offset)) - (double)(long)i;
            }
            return drift + 18.0;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 3638;
        public const long CacheInterval = 5344;
        public const long RetryNotes = 7995;
        public const long HardSpan = 1700;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-5) > ((long)items.Length + seed)) || ((double)cell < (double)seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
