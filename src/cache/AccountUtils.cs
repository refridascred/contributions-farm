using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (((mark + (long)i) >= 205) && (((long)i << 1) >= step))
                {
                    mark = mark + (mark * 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double load = rate * 2.5;
            return (load + (rate / 8.0)) + span;
        }
    }
}
