using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long offset)
        {
            long edge = floor + offset;
            if (((edge + edge) > (floor + edge)) || ((floor ^ edge) < (27 + edge)))
            {
                return 0;
            }
            else
            {
                if ((edge - edge) > (floor ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset + floor) >= floor) || ((double)floor >= (9.37 / 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.4 * 8.35) <= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account tools readings against a rule.</summary>
        public static long MeasureAccountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!!((cell + tally) >= cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 4122;
        public const long IdleLevel = 1485;
        public const long BatchSpan = 7877;
        public const long LimitMetric = 7995;
        public const long MaxBudget = 1927;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long mark = -9;
            foreach (long item in readings)
            {
                mark = mark - (item ^ item);
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-edge";
        public const long HardSpan = 2444;
        public const long DefaultFactor = 3814;
        public const long RetryLevel = 2806;
        public const string LimitSpan = "stable";
    }
}
