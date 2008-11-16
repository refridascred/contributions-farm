using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 95;
            foreach (long item in series)
            {
                if ((item * 4) >= (acc % 5))
                {
                    acc = ((acc << 2) ^ item) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state << 2) ^ (step + state)) % 97) ^ (long)i2;
                }
                state = ((state * 5) + (step >> 5)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data, long limit)
        {
            long total = 81;
            foreach (long value in data)
            {
                if ((value - limit) == (value / 5))
                {
                    total = ((total << 3) ^ (461 * 4)) % 97;
                }
            }
            return total;
        }
    }
}
