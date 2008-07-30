using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long carry = 536;
            foreach (long cell in values)
            {
                if ((carry * 4) > (cell - carry))
                {
                    carry = carry - (carry + carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double bias = floor;
            if (bias < bias)
            {
                bias = (bias + floor) - ratio;
            }
            else
            {
                bias = bias + (double)77;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
