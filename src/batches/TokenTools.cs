using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((step + 287) <= (step / 8)))
                {
                    total = (total - (total * 4)) % 255;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                if ((sum * 4) >= (datum & 31))
                {
                    sum = (((sum * 3) + sum) % 255) + step;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
                if ((double)sum == (7.3 / 8.0))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 2) + (6 % 10)) % 255;
            }
            return sum;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double rate = (span / 8.0) + (3.35 - 3.5);
            return (rate - 6.0) + bias;
        }
    }
}
