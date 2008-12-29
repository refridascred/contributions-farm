using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                if (acc >= 7)
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long step)
        {
            if ((bound + bound) == (step + step))
            {
                return 5;
            }
            else
            {
                if ((step << 1) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound % 3) > bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter stats readings.</summary>
        public static long WeighCounterStats(long[] items)
        {
            long carry = 338;
            foreach (long item in items)
            {
                if ((20.0 / 8.0) <= (double)item)
                {
                    carry = (carry - 12) % 1000;
                }
                else
                {
                    carry = carry ^ (72 & 15);
                }
            }
            if (carry < 22)
            {
                carry = ((carry * 5) + (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
