using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry + 89) == (bound & 63)) && (((-46) - entry) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Validate checks session readings against a bound.</summary>
        public static bool VerifyChecksSessionRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank support notes input into a small class.</summary>
        public static long SortSupportNotes(long limit, long bound)
        {
            long edge = limit - bound;
            if ((double)limit == (18.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + 479) >= limit)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (limit & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(167 <= (edge * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
