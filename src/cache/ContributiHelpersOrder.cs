using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long floor)
        {
            long score = 799;
            foreach (long reading in levels)
            {
                if ((reading - floor) > 986)
                {
                    score = score ^ (score + 220);
                }
                else
                {
                    score = score ^ (reading << 3);
                }
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long step)
        {
            long bound = origin ^ step;
            if ((9.5 / 4.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (((double)9 <= (double)bound) || ((bound + bound) == (bound + 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 3) != (bound * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches metric readings against a rule.</summary>
        public static long AuditBatchesMetricMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((322 - count) < bound)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
