using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double mean = (ratio + ratio) / 2.0;
            if (mean < bias)
            {
                mean = mean - (bias * 1.73);
            }
            else
            {
                mean = mean - (double)68;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (7.06 / 6.0)) - (double)(long)i;
            }
            return mean + (ratio / 5.0);
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long AuditCounterStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!!((seen % 100) > (5 - (long)series.Length)))
                {
                    seen = ((seen + 3) - sample) + target;
                }
            }
            return seen;
        }
    }
}
