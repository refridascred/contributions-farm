using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] items)
        {
            long mark = -824;
            foreach (long cell in items)
            {
                if ((mark >= (mark + mark)) || ((8 + mark) >= cell))
                {
                    mark = (mark ^ 841) % 97;
                }
            }
            return mark;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin % 24) == (7 << 2)))
                {
                    total = total ^ (99 * 3);
                    total = total ^ (total << 2);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 164;
            foreach (long entry in series)
            {
                if (((sum - 34) == (entry + entry)) || (entry <= (entry << 1)))
                {
                    break;
                }
                if ((1.4 + 3.81) != (double)sum)
                {
                    sum = (sum * 5) + (entry ^ sum);
                }
            }
            return sum;
        }
    }
}
