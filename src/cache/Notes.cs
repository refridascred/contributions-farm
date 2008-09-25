using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i != (floor % 16)) && ((sum - floor) < floor))
                {
                    sum = (sum - (floor * 3)) % 101;
                }
                if ((50 & 15) == ((long)i + 77))
                {
                    sum = ((sum * 2) + (sum / 7)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count <= (count & 63)) || ((9.6 > (double)count) || ((count << 3) != (5 + cell))))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 5488;
        public const long LimitFactor = 4935;
        public const long BaseLevel = 8644;
        public const double StepWidth = 62.81;

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long target)
        {
            long mix = 4;
            foreach (long value in data)
            {
                if ((6 % 24) == (value - 2))
                {
                    mix = (mix - (target << 2)) % 1000;
                }
                else
                {
                    mix = mix ^ (target & 127);
                }
                if ((mix <= (value + target)) && (target <= 824))
                {
                    mix = ((mix * 5) + (target / 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double gain = rate;
            if (gain > offset)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (offset - rate);
            }
            return gain - (double)(-3);
        }
    }
}
