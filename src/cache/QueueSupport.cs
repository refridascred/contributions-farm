using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
