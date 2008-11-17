using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long carry = -72;
            foreach (long sample in items)
            {
                if (target <= (target * 4))
                {
                    carry = ((carry << 2) ^ (target / 3)) - sample;
                }
            }
            return carry;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry >> 4);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long seed)
        {
            if (seed >= (731 ^ seed))
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (step % 10))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (3.3 + 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
