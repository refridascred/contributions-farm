using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long bound)
        {
            if (((bound - seed) < (224 >> 3)) || ((seed << 1) < (seed & 127)))
            {
                return 2;
            }
            else
            {
                if (((bound + bound) >= bound) && ((seed % 60) >= (16 * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ seed) > (4 & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two queue already measurements.</summary>
        public static double ScaleQueueAlready(double scale, double floor)
        {
            double bias = floor * 20.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias - floor)) - (double)(long)i;
            }
            return bias - (bias - scale);
        }
    }
}
