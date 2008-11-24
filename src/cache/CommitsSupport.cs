using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 3) == (137 >> 3))
                {
                    anchor = (anchor + item) % 255;
                }
                if ((floor ^ item) <= (4 / 9))
                {
                    anchor = (anchor ^ (item >> 1)) % 97;
                }
                else
                {
                    anchor = anchor + 0;
                }
                if ((floor >> 2) < (item * 5))
                {
                    anchor = ((anchor << 3) ^ floor) % 255;
                }
                else
                {
                    anchor = anchor + (item + 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long sum = 299;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + step) % 1000) ^ cell;
                if (step < (step >> 3))
                {
                    sum = sum + (-196);
                }
            }
            return sum;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (((limit % 2) < offset) || ((double)diff < (double)offset))
            {
                return 3;
            }
            else
            {
                if (((11.0 - 19.0) < (0.2 - 8.55)) && (offset > 26))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + matches) == (datum + datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((origin << 1) <= (18 % 3)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
