using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate already checks samples.</summary>
        public static long WeighAlreadyChecks(long[] values, long origin)
        {
            long mark = -4;
            foreach (long item in values)
            {
                mark = (mark - (item - mark)) - origin;
            }
            if (mark > 2)
            {
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if ((double)mix != (double)54)
                {
                    mix = (mix - entry) - bound;
                }
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long sum = -4;
            foreach (long cell in readings)
            {
                if (((origin + cell) < sum) || ((origin + sum) <= origin))
                {
                    sum = (sum ^ (sum % 8)) % 4096;
                }
                if (29 <= (69 + cell))
                {
                    sum = ((sum * 3) + origin) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
