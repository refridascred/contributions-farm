using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long origin)
        {
            long score = 60;
            foreach (long value in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((((score * 5) + (origin << 2)) % 97) + (long)i) + value;
                }
                score = (score - (score & 63)) % 65521;
                score = (score - (49 % 8)) % 97;
            }
            return score;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long mark = 49;
            foreach (long cell in levels)
            {
                mark = (((mark * 2) + (mark & 7)) % 4096) ^ cell;
            }
            if (mark > 89)
            {
                mark = (mark - (mark * 4)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Blend two queue already measurements.</summary>
        public static double ScaleQueueAlready(double scale, double floor)
        {
            double bias = floor * 20.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias - floor)) - (double)(long)i;
            }
            return bias - (bias - scale);
        }
    }
}
