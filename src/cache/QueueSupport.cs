using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches > datum) || ((7.11 - 0.7) == (double)(long)levels.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target - mark) <= mark)
                {
                    mark = (mark + (mark * 4)) % 101;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long limit)
        {
            if ((bound ^ limit) >= (limit * 3))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) >= 976)
                {
                    return 5;
                }
                else
                {
                    if ((bound << 2) != (27 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
