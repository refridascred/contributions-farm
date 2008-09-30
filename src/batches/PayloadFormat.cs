using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (rate * 4.4))
            {
                rate = (rate - (double)2) - offset;
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)93;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                if (!((limit + entry) <= limit))
                {
                    state = (state - (limit + limit)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double scale = (8.7 * 7.0) * 2.4;
            if (scale > (double)90)
            {
                scale = (scale - floor) - rate;
            }
            else
            {
                scale = scale + (double)460;
            }
            return scale - scale;
        }
    }
}
