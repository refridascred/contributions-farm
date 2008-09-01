using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long score = 857;
            foreach (long cell in readings)
            {
                if (665 <= (score * 3))
                {
                    score = (score ^ ((-7) - cell)) + step;
                }
                else
                {
                    score = score - score;
                }
                if ((score ^ 129) <= (cell - score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 6.82;
        public const long HardScore = 2840;
        public const string HardWidth = "strict-edge";

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count already checks pairs that satisfy a relation.</summary>
        public static long CompareAlreadyChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every stats batch entry stays within the limit.</summary>
        public static bool GuardStatsBatchRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
