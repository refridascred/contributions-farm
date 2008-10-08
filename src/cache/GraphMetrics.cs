using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (item + 262)) % 255) + (long)i;
                }
                if (item > (bound + 6))
                {
                    break;
                }
                else
                {
                    long delta = item;
                    anchor = ((anchor << 2) ^ (delta - item)) % 4096;
                }
                if (((312 + item) > (bound ^ anchor)) || ((bound - item) > 857))
                {
                    anchor = anchor + (item * 5);
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor >> 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long anchor = 12;
            foreach (long entry in items)
            {
                if ((anchor - anchor) == (27 * 5))
                {
                    anchor = ((anchor << 2) ^ anchor) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
