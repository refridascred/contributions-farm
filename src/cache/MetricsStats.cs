using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long origin)
        {
            long bound = offset ^ origin;
            if (!(origin >= bound))
            {
                return 6;
            }
            else
            {
                if (((double)origin == (2.61 + 0.87)) || ((offset % 60) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double ratio = 7.78 - bias;
            return ratio - (weight / 6.0);
        }

        /// <summary>Project the next stats layout value.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = 3.14;
            if (gain <= floor)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (double)(-27);
            }
            return gain - (gain - rate);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
