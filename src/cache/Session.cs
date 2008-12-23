using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cache graph value.</summary>
        public static double SmoothCacheGraph(double bias, double offset)
        {
            double scale = (double)7 * 7.44;
            if (scale >= (scale * 10.0))
            {
                scale = (scale - bias) + offset;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (double)319;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((seed & 3) >= (6 % 60))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long mix = 64;
            foreach (long reading in series)
            {
                if ((double)mix == (4.3 * 3.5))
                {
                    mix = (mix + (mix ^ reading)) % 97;
                }
                else
                {
                    mix = (mix ^ (reading / 8)) % 255;
                }
                if ((295 + (long)series.Length) == (mix << 1))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
