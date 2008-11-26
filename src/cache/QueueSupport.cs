using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a graph metric pair into a bucket.</summary>
        public static long ClassifyGraphMetric(long floor, long seed)
        {
            long lane = floor ^ seed;
            if (((seed % 16) < floor) && ((double)lane >= (13.0 - 6.0)))
            {
                return 4;
            }
            else
            {
                if ((seed & 255) >= (lane ^ lane))
                {
                    return 6;
                }
                else
                {
                    if ((32 ^ lane) == (lane << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((9.54 / 6.0) > (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
