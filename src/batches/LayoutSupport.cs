using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double weight = bias2;
            if (weight > (double)(-1))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (bias2 - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count < (count * 4)) && ((397 + entry) == (entry - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm already entry stays within the limit.</summary>
        public static bool GuardGithubfarmAlreadyLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
