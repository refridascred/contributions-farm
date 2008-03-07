using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the stats account series from a seed.</summary>
        public static long DeriveStatsAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mark <= (mark * 3)) || ((mark % 100) < (mark - offset)))
                {
                    mark = mark + (offset / 9);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long CombineSchemaRecord(long[] levels, long floor)
        {
            long mark = 473;
            foreach (long datum in levels)
            {
                mark = ((mark * 5) + (0 - mark)) % 101;
                mark = (mark * 4) + (floor ^ 670);
                if ((datum << 1) != (floor << 1))
                {
                    mark = (mark - (0 * 3)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
