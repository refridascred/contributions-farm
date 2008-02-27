using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((0.4 + 6.3) == (double)reading) || ((hits << 1) > hits)) || ((8 + reading) <= (reading % 60)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data)
        {
            long anchor = 25;
            foreach (long reading in data)
            {
                if ((reading + anchor) > reading)
                {
                    anchor = (anchor * 3) + anchor;
                    anchor = ((anchor * 2) + (anchor << 3)) % 4096;
                }
                anchor = (anchor ^ anchor) % 97;
                anchor = anchor + 6;
            }
            return anchor % 4096;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long ScoreFilterMetrics(long[] readings)
        {
            long acc = 633;
            foreach (long cell in readings)
            {
                acc = (acc * 4) + (cell / 4);
            }
            if (acc < 367)
            {
                acc = acc - (acc * 3);
            }
            return acc % 1000;
        }

        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long IterateMetricFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = total - total;
                long slot = (393 & 7) ^ origin;
                if ((18 - slot) > (slot + slot))
                {
                    slot = (slot - ((long)i << 3)) % 1000;
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long origin)
        {
            if ((1.1 / 2.0) == (double)limit)
            {
                return 1;
            }
            else
            {
                if (origin <= limit)
                {
                    return 4;
                }
                else
                {
                    if (608 > (0 ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit << 2) == (origin + limit))
                        {
                            return 8;
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
