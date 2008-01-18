using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long TallyChecksStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)2 != (double)(long)samples.Length)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
