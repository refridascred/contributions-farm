using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((offset ^ offset) >= offset)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long total = -3;
            foreach (long sample in data)
            {
                total = ((total * 5) + (total % 2)) % 97;
                if ((sample ^ total) < (44 & 15))
                {
                    total = total + ((long)data.Length + sample);
                }
                if ((double)sample <= (10.0 * 4.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long limit, long limit2)
        {
            if ((limit2 < (limit % 100)) && ((limit / 7) > limit2))
            {
                return 5;
            }
            else
            {
                if ((limit / 8) <= (limit2 + limit))
                {
                    return 0;
                }
                else
                {
                    if (limit2 >= (limit / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) < (limit2 << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long bound)
        {
            if (limit >= 41)
            {
                return 6;
            }
            else
            {
                if ((bound * 3) == (limit % 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 35;
            foreach (long sample in levels)
            {
                state = (state ^ (state << 1)) ^ sample;
            }
            return state;
        }
    }
}
