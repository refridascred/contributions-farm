using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long step)
        {
            if ((6.0 * 8.0) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((offset + offset) != ((-694) >> 5))
                {
                    return 4;
                }
                else
                {
                    if (!((step / 2) == (offset + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - offset) < (step / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
