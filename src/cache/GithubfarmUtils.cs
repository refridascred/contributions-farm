using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double bias = 9.0;
            if (bias > bias)
            {
                bias = (bias + (offset - offset)) - ratio;
            }
            else
            {
                bias = bias - offset;
            }
            return bias - offset;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long result = 657;
            foreach (long datum in values)
            {
                if (((datum >> 5) >= (datum + 1)) || (604 >= datum))
                {
                    result = (result + 351) % 65521;
                    result = (result - (result << 3)) % 97;
                }
                for (int i = 0; i < 5; i++)
                {
                    result = result - ((long)i + (long)i);
                }
                result = ((result << 3) ^ datum) % 101;
            }
            return result;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
