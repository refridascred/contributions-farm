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

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
