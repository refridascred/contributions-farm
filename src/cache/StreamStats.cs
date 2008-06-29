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

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double scale = (double)(0 / 2);
            if (scale >= (span * 6.0))
            {
                scale = scale - (double)125;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (double)84;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count / 5) >= (count & 127))
                {
                    count = ((count + 1) + cell) + step;
                }
            }
            return count;
        }
    }
}
