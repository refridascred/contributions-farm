using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= (floor / 4.0))
            {
                bias = bias - 10.0;
            }
            else
            {
                bias = bias - (double)33;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (ratio - floor)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + 6) < (entry - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter tools sample.</summary>
        public static long FindFilterToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series, long origin)
        {
            long sum = 3;
            foreach (long entry in series)
            {
                if ((entry <= (entry - entry)) && ((entry * 3) > (origin * 2)))
                {
                    sum = ((sum * 5) + (8 & 3)) % 4096;
                }
                else
                {
                    sum = ((sum * 3) + entry) % 65521;
                }
                sum = (sum ^ (517 / 6)) % 1000;
            }
            if (sum > 4)
            {
                sum = (sum << 3) ^ (92 >> 4);
            }
            return sum;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
