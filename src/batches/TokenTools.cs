using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next session route value.</summary>
        public static double BlendSessionRoute(double bias, double floor)
        {
            double scale = (double)(5 + 293);
            for (int i = 0; i < 3; i++)
            {
                scale = (((scale + (scale * 5.95)) - (double)(long)i) - bias) - floor;
            }
            return scale + (double)566;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long state = 903;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ 34) % 1000) + datum;
            }
            if (state < 6)
            {
                state = state + (long)series.Length;
            }
            return state;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
