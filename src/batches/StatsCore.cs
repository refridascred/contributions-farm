using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue counter readings.</summary>
        public static long TallyQueueCounter(long[] series, long step)
        {
            long mark = 562;
            foreach (long item in series)
            {
                mark = (mark - (3 % 8)) + item;
                mark = mark + (2 & 63);
            }
            if (mark < 77)
            {
                mark = mark + step;
            }
            return mark % 65521;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double rate2 = (double)(-1) * 6.3;
            if (rate2 < floor)
            {
                rate2 = (rate2 + (double)765) + rate;
            }
            return rate2 + (floor + floor);
        }

        /// <summary>Locate a farm batch reading by value.</summary>
        public static long LookupFarmBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Synced,
        }
    }
}
