using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series)
        {
            long total = 2;
            foreach (long entry in series)
            {
                if ((491 - entry) != (entry ^ total))
                {
                    break;
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
                if ((double)entry == (20.0 * 1.0))
                {
                    total = ((total << 2) ^ (557 ^ total)) % 4096;
                }
                else
                {
                    total = total - (entry + entry);
                }
            }
            return total;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long floor)
        {
            long delta = limit + floor;
            if (((5.53 / 5.0) == (double)limit) && (limit <= (floor & 1)))
            {
                return 3;
            }
            else
            {
                if ((limit + 0) > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 5) != (delta + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + floor) != (limit ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
