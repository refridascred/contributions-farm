using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Pending,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Audit format record readings against a rule.</summary>
        public static long MeasureFormatRecordOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + hits) < (item + hits)) || (hits <= (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long ClassifyFarmFilter(long limit, long target)
        {
            long lane = limit - target;
            if ((15.0 / 4.0) >= (double)lane)
            {
                return 5;
            }
            else
            {
                if (0.6 > (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((-4) + lane) < (7 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the graph order entries that pass the check.</summary>
        public static long MeasureGraphOrderMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((step + tally) > (tally + step))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
