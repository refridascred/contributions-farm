using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark << 3) ^ 9;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next checks batches value from a seed.</summary>
        public static long IterateChecksBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(total >= (total & 7)))
                {
                    total = total - (49 << 3);
                }
                if (total <= (total - origin))
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total * 3) + (total % 16);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double floor)
        {
            double scale = (ratio - ratio) / 4.0;
            if (scale < (scale / 6.0))
            {
                scale = scale - 12.0;
            }
            return scale + (floor / 5.0);
        }
    }
}
