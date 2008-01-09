using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double gain = rate;
            return gain + (bias * 4.56);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long floor)
        {
            long step = seed + floor;
            if ((1.1 - 2.0) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((step << 3) > (seed >> 4))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((4.68 - 14.0) <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
