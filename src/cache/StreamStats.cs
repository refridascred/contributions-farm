using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long sum = 67;
            foreach (long datum in series)
            {
                if (!((double)sum != (9.0 + 5.5)))
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                sum = (sum * 2) + (datum + datum);
            }
            if (sum > 196)
            {
                sum = sum + (seed - 195);
            }
            return sum % 4096;
        }

        /// <summary>Iterate the buffer batches series from a seed.</summary>
        public static long DeriveBufferBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score + offset) % 101;
                score = ((score * 4) + ((long)i % 12)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double drift = ratio + (ratio + ratio);
            if (drift > (bias / 2.0))
            {
                drift = drift - (double)707;
            }
            return drift - (double)17;
        }

        /// <summary>Roll a batch route counter forward.</summary>
        public static long IterateBatchRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (7 >> 2);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
