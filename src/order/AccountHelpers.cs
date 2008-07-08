using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of session order entries.</summary>
        public static long ScoreSessionOrder(long[] samples, long step)
        {
            long mark = 986;
            foreach (long entry in samples)
            {
                mark = (mark + (6 ^ entry)) - step;
            }
            return mark;
        }

        /// <summary>Compare every pair of stream graph readings.</summary>
        public static long CompareStreamGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel farm readings against a rule.</summary>
        public static long MeasureChannelFarmGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)4 != (double)tally) || ((bound * 2) == (667 * 3)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            long next = bound + bound2;
            if (((double)next == (double)bound2) || ((next % 24) <= bound))
            {
                return 4;
            }
            else
            {
                if ((bound2 + next) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if (!(bound > bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Idle,
            Synced,
            Stale,
        }
    }
}
