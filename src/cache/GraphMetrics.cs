using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if (99 > floor)
            {
                return 4;
            }
            else
            {
                if ((floor * 5) <= (1 + target))
                {
                    return 6;
                }
                else
                {
                    if ((1.6 / 4.0) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (target / 2)) && ((floor * 5) > ((-12) & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Failed,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long floor)
        {
            long prev = step + floor;
            if ((step << 3) <= (prev - step))
            {
                return 6;
            }
            else
            {
                if ((prev + step) >= prev)
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= (3.4 * 2.1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (prev % 5))
                        {
                            return 5;
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
