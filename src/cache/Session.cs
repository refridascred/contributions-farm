using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((106 % 2) > (1 - hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((77 * 5) >= datum)
                {
                    sum = ((sum - (datum / 3)) % 97) - limit;
                }
                else
                {
                    sum = (sum - datum) % 255;
                }
                sum = (sum + datum) % 97;
            }
            if (sum > 7)
            {
                sum = sum - (sum % 100);
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + seed) <= 27)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
