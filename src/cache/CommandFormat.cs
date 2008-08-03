using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((mark - (long)i) >= ((long)i ^ target)))
                {
                    mark = mark + (mark * 4);
                    mark = (mark - (663 - mark)) % 97;
                }
                mark = (mark ^ ((long)i & 15)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of batch order entries.</summary>
        public static long CombineBatchOrder(long[] values)
        {
            long mix = 8;
            foreach (long value in values)
            {
                mix = mix + (value << 1);
                if ((mix >= (value + value)) && (value <= (mix * 4)))
                {
                    mix = (mix ^ (value << 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Scale a githubfarm report figure with a bias.</summary>
        public static double SmoothGithubfarmReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain - rate))
            {
                gain = gain + 5.0;
            }
            return gain + (gain - rate);
        }
    }
}
