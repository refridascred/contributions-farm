using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double load = (4.4 + 11.0) + (8.2 * 9.9);
            if (load >= (double)3)
            {
                load = load - scale;
            }
            return load - offset;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 + bias2) + bias;
        }
    }
}
