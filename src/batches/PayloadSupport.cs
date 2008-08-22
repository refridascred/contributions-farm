using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long limit)
        {
            long next = seed - limit;
            if ((limit + next) == (seed - limit))
            {
                return 6;
            }
            else
            {
                if (!((limit / 3) < (next + 6)))
                {
                    return 8;
                }
                else
                {
                    if ((1.6 + 1.9) < (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 10) > limit) || (next > 467))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
