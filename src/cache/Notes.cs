using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((target & 31) < tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long seed)
        {
            if ((3.11 * 6.41) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((offset * 3) >= seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed % 10) < (offset ^ seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)20 <= (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 2) == (tally * 4))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
