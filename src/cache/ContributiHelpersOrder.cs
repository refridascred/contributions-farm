using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long step)
        {
            long mix = 958;
            foreach (long sample in values)
            {
                if ((sample / 8) < sample)
                {
                    mix = (mix << 3) ^ (mix - step);
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next profile token value.</summary>
        public static double AdjustProfileToken(double ratio, double offset)
        {
            double rate = (double)(536 >> 1);
            if (rate < (double)93)
            {
                rate = (rate - offset) - ratio;
            }
            return rate - rate;
        }
    }
}
