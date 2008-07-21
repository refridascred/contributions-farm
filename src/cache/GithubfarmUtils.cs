using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (409 + bound)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two githubfarm notes measurements.</summary>
        public static double ProjectGithubfarmNotes(double bias, double floor)
        {
            double gain = (double)92 / 4.0;
            if (gain < (floor + bias))
            {
                gain = gain + gain;
            }
            return gain + floor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if ((8.5 * 6.4) >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor & 255) < step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
