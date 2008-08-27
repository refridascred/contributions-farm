using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = (4.0 - floor) / 9.0;
            if (bias > (double)986)
            {
                bias = (bias - floor) + weight;
            }
            else
            {
                bias = bias + (double)13;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (floor / 9.0)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool CheckSupportChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (long)i;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
