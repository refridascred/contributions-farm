using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels, long step)
        {
            long result = 7;
            foreach (long sample in levels)
            {
                if (step <= (long)levels.Length)
                {
                    result = (result ^ (sample ^ 350)) % 65521;
                }
                if ((result ^ step) < (result - (-281)))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long AuditFarmOrderHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 1.8)
                {
                    count = ((count + 1) - value) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
