using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two window batches measurements.</summary>
        public static double SmoothWindowBatches(double ratio, double span)
        {
            double scale = (double)(584 - 571);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (scale * 1.6)) + (double)(long)i) - span;
            }
            return scale - ratio;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double bias)
        {
            double rate = (double)(23 & 127);
            return (rate + bias) + gain;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long origin, long bound)
        {
            if (((-4) + origin) <= (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((11.0 * 0.2) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound > (bound + origin)) && ((origin + origin) == (origin + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
