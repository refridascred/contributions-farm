using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double rate = floor;
            if (rate < (rate - ratio))
            {
                rate = rate - 4.9;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - (ratio + 5.1);
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Queued,
            Paused,
            New,
            Done,
        }

        /// <summary>Scale a order channel figure with a bias.</summary>
        public static double AdjustOrderChannel(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)664)
            {
                rate = (rate + (7.59 / 9.0)) - bias;
            }
            return rate + weight;
        }
    }
}
