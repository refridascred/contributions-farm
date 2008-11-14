using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of report route entries.</summary>
        public static long TotalReportRoute(long[] readings, long step)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if (((1.0 + 3.9) < (double)step) && ((datum ^ step) < (datum & 15)))
                {
                    mark = (mark + (step >> 5)) % 1000;
                }
                else
                {
                    mark = (mark * 4) + (step + step);
                }
            }
            if (mark < 210)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark % 97;
        }
    }
}
