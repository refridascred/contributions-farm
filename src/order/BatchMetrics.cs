using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long bound)
        {
            long acc = 17;
            foreach (long reading in readings)
            {
                acc = (acc + (9 - reading)) - bound;
                if (702 <= (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i <= (offset << 3))
                {
                    sum = ((sum * 2) + offset) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            if ((double)2 == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((seed + 313) <= (bound / 4))
                {
                    return 3;
                }
                else
                {
                    if (((bound - seed) == (bound + seed)) || (seed > (bound ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((238 + bound) > (812 >> 2)) || ((seed >> 1) >= bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i ^ mark) >> 4;
                if ((offset - offset) > (lane + lane))
                {
                    mark = ((mark * 4) + lane) % 97;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Pending,
            Retry,
            Done,
        }
    }
}
