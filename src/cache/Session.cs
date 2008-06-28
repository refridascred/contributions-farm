using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading < (reading ^ reading)) || ((total >> 2) == (reading & 127)))
                {
                    total = total ^ (total / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Count order tools pairs that satisfy a relation.</summary>
        public static long PairOrderToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long bound)
        {
            long score = 82;
            foreach (long entry in readings)
            {
                if (((-23) + bound) <= (score + score))
                {
                    score = ((score << 2) ^ (entry / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double scale = bias;
            if (scale > (scale * 4.0))
            {
                scale = (scale - (bias - bias)) + ratio;
            }
            else
            {
                scale = scale - 1.61;
            }
            return scale - (double)741;
        }
    }
}
