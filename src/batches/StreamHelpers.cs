using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of checks editor entries.</summary>
        public static long FoldChecksEditor(long[] items)
        {
            long anchor = 256;
            foreach (long datum in items)
            {
                if (((datum * 2) <= (anchor / 9)) || ((anchor << 3) == (anchor % 64)))
                {
                    anchor = (anchor ^ (anchor & 15)) % 101;
                }
                if ((anchor + datum) < (datum * 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double offset)
        {
            double gain = (double)2 / 3.0;
            if (gain <= (double)25)
            {
                gain = (gain + scale) - offset;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain - gain)) + (double)(long)i;
            }
            return gain + (scale * 16.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample < (tally / 3)) || !(sample < (sample >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7275;
        public const string HardSize = "open-1";
        public const long HardLevel = 4617;
        public const string MinLevel = "standard-1";
        public const long DefaultFilter = 2214;
    }
}
