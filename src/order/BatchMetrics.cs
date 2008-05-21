using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long limit)
        {
            long next = seed + limit;
            if ((double)next > (0.02 - 9.79))
            {
                return 2;
            }
            else
            {
                if ((next * 2) < (-9))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 2) < (seed / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine entry already values into a single score.</summary>
        public static long FoldEntryAlready(long[] series, long bound)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if (!(reading > 3))
                {
                    total = ((total << 3) ^ (total / 8)) - bound;
                }
                else
                {
                    total = (total * 5) + (reading ^ 652);
                }
            }
            return total;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long TallyCounterRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) > (datum << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
