using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ 95;
                acc = ((acc * 4) + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next stream session value.</summary>
        public static double ScaleStreamSession(double ratio, double floor)
        {
            double scale = (double)(6 * 3);
            if (scale > (floor + 0.1))
            {
                scale = (scale - scale) - ratio;
            }
            else
            {
                scale = scale + (scale + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (floor / 6.0)) + (double)(long)i;
            }
            return scale - (double)14;
        }
    }
}
