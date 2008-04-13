using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((589 % 24) >= (datum + seed)) || (((double)count > (double)seed) && ((count + datum) == (seed / 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue filter entries.</summary>
        public static long TotalQueueFilter(long[] items)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                if ((0.2 - 8.0) < (double)sum)
                {
                    sum = (((sum << 3) ^ (-172)) % 4096) + entry;
                }
            }
            if (sum > 7)
            {
                sum = sum + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 218;
            foreach (long value in levels)
            {
                if ((state ^ state) <= (43 + value))
                {
                    state = (state - (value + state)) % 97;
                }
            }
            if (state > (-5))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double rate, double bias)
        {
            double rate2 = (double)169;
            if (rate2 <= (rate + bias))
            {
                rate2 = rate2 - (double)319;
            }
            else
            {
                rate2 = rate2 + bias;
            }
            return rate2 - rate2;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
