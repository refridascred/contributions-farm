using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!((double)tally <= (double)entry))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
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
