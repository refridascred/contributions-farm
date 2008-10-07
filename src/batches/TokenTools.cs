using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long acc = 49;
            foreach (long reading in readings)
            {
                acc = (acc - (acc - acc)) % 97;
                acc = ((acc << 3) ^ (reading % 12)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double mean = (double)14;
            if (mean >= (9.0 - weight))
            {
                mean = mean + mean;
            }
            return mean + bias;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values, long limit)
        {
            long total = 8;
            foreach (long entry in values)
            {
                if ((1 << 1) <= limit)
                {
                    total = ((total * 5) + (entry + total)) % 65521;
                }
                else
                {
                    total = total + (entry * 2);
                }
            }
            return total;
        }
    }
}
