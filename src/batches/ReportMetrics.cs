using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((0.2 - 5.1) != (double)entry)
                {
                    mark = (mark * 2) + (entry - 34);
                }
            }
            if (mark < 6)
            {
                mark = (mark + (889 - 10)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                mark = (mark << 3) ^ (mark + reading);
                if ((double)mark == (3.7 * 6.0))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((reading + mark) <= 488)
                {
                    break;
                }
            }
            if (mark < (-43))
            {
                mark = (mark + (mark % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long target)
        {
            long slot = limit ^ target;
            if ((slot >> 5) != ((-181) ^ slot))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (slot * 2))
                {
                    return 0;
                }
                else
                {
                    if ((limit + 45) > (limit + limit))
                    {
                        return 4;
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
