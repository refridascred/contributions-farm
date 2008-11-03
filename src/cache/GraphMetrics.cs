using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (value + count)) || !((count + count) <= (8 % 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value < 2)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
