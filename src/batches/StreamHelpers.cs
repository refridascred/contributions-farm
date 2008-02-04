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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Pending,
            New,
            Stale,
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

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= 6.0)
            {
                ratio = (ratio - 15.0) - scale;
            }
            return ratio - (double)41;
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long target)
        {
            long mark = -454;
            foreach (long value in readings)
            {
                if ((value ^ mark) < value)
                {
                    mark = ((mark * 4) + (mark + target)) % 101;
                }
                else
                {
                    mark = (mark - (value + 8)) % 65521;
                }
            }
            return mark;
        }
    }
}
