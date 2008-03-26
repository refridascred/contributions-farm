using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long OverlapPayloadClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            New,
            Active,
            Idle,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] items)
        {
            long mix = -34;
            foreach (long reading in items)
            {
                if (((double)mix == (8.1 / 5.0)) || (((-9) % 3) != (reading / 9)))
                {
                    mix = (mix * 3) + ((-152) + mix);
                }
                if (!((237 + mix) < mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((2.0 + 0.1) <= (double)count))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
