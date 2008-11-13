using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i < (10.0 * 6.4))
                {
                    mark = mark ^ mark;
                    mark = (mark + (507 - mark)) % 1000;
                    continue;
                }
                else
                {
                    mark = mark + (offset + mark);
                    mark = ((mark << 3) ^ (offset + 661)) % 255;
                }
                mark = ((mark << 2) ^ (offset ^ mark)) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double scale, double span)
        {
            double gain = (double)(359 * 5);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + (scale + scale);
        }
    }
}
