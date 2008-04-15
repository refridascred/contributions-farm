using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batches already counter forward.</summary>
        public static long SeriesBatchesAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((acc >> 2) > (offset & 31)))
                {
                    acc = acc - (offset + (long)i);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long ScoreCounterQueue(long[] data, long limit)
        {
            long state = 78;
            foreach (long item in data)
            {
                if (4 <= state)
                {
                    state = (state ^ (item / 8)) - limit;
                }
            }
            if (state < 5)
            {
                state = ((state << 3) ^ ((long)data.Length >> 3)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((3.0 / 2.0) <= (double)sum)
                {
                    sum = (sum ^ (long)i) % 255;
                }
                else
                {
                    sum = (sum - floor) % 4096;
                }
                if ((sum % 10) > (sum * 5))
                {
                    sum = ((sum << 2) ^ (sum & 31)) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum - ((long)i >> 3)) % 4096) ^ (long)i2;
                    sum = ((sum * 2) + (floor + (-373))) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
