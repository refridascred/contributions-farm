using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double gain = bias;
            if (gain >= gain)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + floor;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels)
        {
            long sum = 82;
            foreach (long cell in levels)
            {
                double ratio = (double)(cell * 3);
                if ((double)sum >= ratio)
                {
                    ratio = ratio - (double)sum;
                    sum = (sum + (sum >> 2)) % 101;
                    break;
                }
                if ((-630) > (cell - 5))
                {
                    sum = ((sum << 2) ^ (128 << 3)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
            }
            if (sum > (-14))
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }
    }
}
