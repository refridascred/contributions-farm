using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long origin)
        {
            long mark = 66;
            foreach (long reading in levels)
            {
                mark = ((mark + mark) % 97) + origin;
                mark = (mark ^ (reading + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double load = offset + bias;
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + offset;
        }
    }
}
