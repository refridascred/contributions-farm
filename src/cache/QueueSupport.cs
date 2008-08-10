using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a batches layout pair into a bucket.</summary>
        public static long ClassifyBatchesLayout(long step, long step2)
        {
            long span = step - step2;
            if (((13.0 * 8.0) != (double)step) || ((1.6 / 4.0) > (double)span))
            {
                return 5;
            }
            else
            {
                if ((double)step2 <= (5.2 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if (((step >> 2) < (span + step)) || (step >= (step2 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.5 > (double)step2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items, long limit)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                if (mark >= (mark - mark))
                {
                    mark = (((mark << 3) ^ (mark & 127)) % 101) ^ sample;
                }
                mark = (mark - ((-752) & 7)) % 101;
            }
            if (mark < 29)
            {
                mark = ((mark * 3) + (limit - limit)) % 255;
            }
            return mark;
        }
    }
}
