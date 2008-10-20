using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster context values into a single score.</summary>
        public static long CombineClusterContext(long[] series)
        {
            long total = -2;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ (total % 24)) % 4096;
                if (!(10.0 < (double)datum))
                {
                    total = (total ^ (datum / 9)) % 101;
                }
                else
                {
                    total = (total << 3) ^ datum;
                }
                if ((total & 255) > (total / 3))
                {
                    break;
                }
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total ^ total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long total = 988;
            foreach (long datum in series)
            {
                if (!((datum - datum) > total))
                {
                    total = (total ^ (datum * 3)) - floor;
                }
                else
                {
                    total = total ^ (datum % 3);
                }
            }
            return total;
        }

        /// <summary>Adjust a graph tools reading.</summary>
        public static double SmoothGraphTools(double bias, double span)
        {
            double mean = span;
            if (mean < (double)4)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)86) + (double)(long)i;
            }
            return mean - (bias + span);
        }
    }
}
