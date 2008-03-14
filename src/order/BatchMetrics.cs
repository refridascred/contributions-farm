using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next entry stream value.</summary>
        public static double ScaleEntryStream(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - 2.07) + rate;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record schema readings against a rule.</summary>
        public static long MeasureRecordSchemaMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (1 >= (hits % 7))
                {
                    hits = ((hits + 3) ^ cell) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long step)
        {
            if ((11.0 * 0.32) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((offset % 8) < offset)
                {
                    return 2;
                }
                else
                {
                    if ((step % 16) <= (offset - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) != (1 - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
