using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load > (load + 16.0))
            {
                load = (load + (double)660) - floor;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (scale * 7.0);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
