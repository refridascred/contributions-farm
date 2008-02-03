using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading % 100) > (count ^ offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank context stats input into a small class.</summary>
        public static long ClassifyContextStats(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((step << 3) < (65 << 2))
            {
                return 7;
            }
            else
            {
                if ((seed * 4) == (seed - step))
                {
                    return 2;
                }
                else
                {
                    if ((80 % 3) > (limit ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step) < (step % 60)) && ((double)step < (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }
    }
}
