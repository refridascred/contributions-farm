using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long total = 4;
            foreach (long entry in values)
            {
                total = (((total * 2) + (bound + 399)) % 255) ^ entry;
            }
            if (total > 285)
            {
                total = total ^ (5 * 5);
            }
            return total % 4096;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(anchor >= (471 + (long)i)))
                {
                    anchor = (anchor ^ (anchor + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double load = (rate / 7.0) * 8.9;
            if (load > (rate / 6.0))
            {
                load = (load + load) - bias;
            }
            return load + rate;
        }
    }
}
