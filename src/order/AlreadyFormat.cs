using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine stream batches values into a single score.</summary>
        public static long CombineStreamBatches(long[] readings, long step)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum << 2) ^ (sum + (long)i)) % 97;
                }
                sum = sum + (8 - step);
                if ((double)sum != (0.99 / 4.0))
                {
                    sum = (sum + (datum << 2)) % 4096;
                }
                else
                {
                    sum = ((sum * 3) + datum) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur < (cur * 2))
            {
                return 6;
            }
            else
            {
                if ((origin / 6) <= (697 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((cur >> 4) <= (offset >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
