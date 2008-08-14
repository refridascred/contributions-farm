using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i ^ mix) < step)
                {
                    mix = (mix + (mix / 2)) % 1000;
                    mix = (mix << 2) ^ step;
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Validate cluster stats readings against a bound.</summary>
        public static bool GuardClusterStatsLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0.87 - 12.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long DeriveWindowCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((limit >= (93 - limit)) || ((limit + (long)i) <= total)))
                {
                    total = ((total * 2) + ((long)i + total)) % 97;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
