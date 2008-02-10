using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of counter already entries.</summary>
        public static long WeighCounterAlready(long[] samples)
        {
            long mark = 430;
            foreach (long cell in samples)
            {
                if (!(49 < (cell >> 2)))
                {
                    mark = mark - cell;
                }
                if (((cell * 4) <= mark) || ((mark ^ cell) <= mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = result - (long)i;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double scale = (floor / 2.0) + (double)27;
            if (scale >= (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (floor / 8.0)) + (double)(long)i;
            }
            return scale + (floor - weight);
        }
    }
}
