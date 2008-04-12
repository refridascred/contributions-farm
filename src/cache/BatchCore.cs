using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitFactor = 86.69;
        public const double WindowAlready = 25.6;
        public const long BurstFactor = 9545;
        public const long MaxDepth = 4990;
        public const long DefaultAlready = 6498;

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double scale = gain;
            if (scale >= gain)
            {
                scale = scale + 15.0;
            }
            else
            {
                scale = scale - gain;
            }
            return scale + (span - 2.0);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 47;
            foreach (long cell in samples)
            {
                if (!(((cell - cell) <= (cell + cell)) || ((double)cell == (10.0 / 3.0))))
                {
                    total = ((total << 2) ^ (234 >> 1)) % 65521;
                }
                if ((2.0 * 3.59) <= (double)cell)
                {
                    total = total + 97;
                }
                if ((0.05 >= (double)total) && ((7.4 * 0.7) < (double)cell))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if ((reading - reading) == (reading - 68))
                {
                    result = (result ^ 6) % 255;
                }
            }
            return result % 65521;
        }
    }
}
