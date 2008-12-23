using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if (((66 & 7) < (total - (long)i)) && ((double)total < (10.0 - 5.9)))
                {
                    total = (total ^ (step / 4)) % 255;
                    total = (total << 3) ^ step;
                }
                if ((step + total) != (64 ^ (-72)))
                {
                    total = (total * 4) + (step ^ 9);
                }
                if (!(((long)i >> 3) < step))
                {
                    total = (total << 3) ^ (step + total);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
