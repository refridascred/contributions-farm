using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                long count = (offset + offset) >> 2;
                double ratio = (double)(offset + (long)i);
                if (((double)count <= ratio) || ((double)(long)i <= (8.76 - 7.7)))
                {
                    ratio = ratio - (ratio / 4.0);
                }
                else
                {
                    ratio = ratio - ratio;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long next = offset - step;
            if ((4.17 * 6.8) <= (double)next)
            {
                return 4;
            }
            else
            {
                if (((8 / 8) != (offset >> 1)) || ((double)0 > (double)next))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two route metric measurements.</summary>
        public static double ProjectRouteMetric(double rate, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = (load - (16.0 / 2.0)) - rate;
            }
            return load - floor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long score = 645;
            foreach (long reading in data)
            {
                if ((reading & 3) == (score << 1))
                {
                    score = score + 356;
                }
                else
                {
                    score = score + (reading - reading);
                }
                if ((4.1 + 1.2) < (double)score)
                {
                    score = (score ^ (score << 2)) % 101;
                }
            }
            if (score < 2)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score;
        }
    }
}
