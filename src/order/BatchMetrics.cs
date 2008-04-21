using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long step)
        {
            long anchor = 59;
            foreach (long cell in samples)
            {
                anchor = (anchor + (anchor + 16)) % 1000;
                anchor = (anchor - (anchor * 2)) % 65521;
                if (((cell / 8) >= anchor) || ((step + anchor) != (cell / 6)))
                {
                    anchor = anchor + step;
                }
                if ((step - cell) < step)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a batch entry reading.</summary>
        public static double ScaleBatchEntry(double gain, double bias)
        {
            double rate = bias;
            if (rate <= rate)
            {
                rate = rate + (double)0;
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + 4.11;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long limit)
        {
            if (((double)offset >= (4.1 / 9.0)) && ((8.7 + 9.91) > (double)offset))
            {
                return 7;
            }
            else
            {
                if ((limit & 7) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((4.89 / 3.0) == (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 1) != (745 * 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long CountBufferOrderHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + limit) == (8 - seen)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
