using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long seed)
        {
            if ((89 ^ seed) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 1.55)
                {
                    return 1;
                }
                else
                {
                    if (!(offset <= (817 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset > (7.0 - 10.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches - matches) >= (offset ^ offset)) && ((entry + offset) != (matches << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up already batch samples.</summary>
        public static long MatchAlreadyBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -1;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell - cell)) % 4096;
                if (!(sum >= (cell - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the stream batches series from a seed.</summary>
        public static long DeriveStreamBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
