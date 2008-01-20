using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next cluster route value from a seed.</summary>
        public static long SeriesClusterRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset / 2) > (sum >> 1))
                {
                    sum = (sum ^ offset) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
