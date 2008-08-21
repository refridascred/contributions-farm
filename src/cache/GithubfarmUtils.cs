using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long floor)
        {
            if (((18.0 * 4.9) <= (double)target) && ((floor + floor) >= target))
            {
                return 3;
            }
            else
            {
                if (floor > (target >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 16) >= (target * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a context entry figure with a bias.</summary>
        public static double ProjectContextEntry(double gain, double floor)
        {
            double mean = gain;
            if (mean < floor)
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a tools stream sample.</summary>
        public static long SeekToolsStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
