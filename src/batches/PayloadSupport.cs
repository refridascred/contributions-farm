using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double bias = 8.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (offset + gain)) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!((((long)i >> 1) >= origin) || (((long)i - anchor) < (560 - anchor))))
                {
                    anchor = ((anchor << 2) ^ (origin * 4)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
