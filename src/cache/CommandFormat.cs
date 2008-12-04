using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long bound)
        {
            if (bound <= (limit + bound))
            {
                return 7;
            }
            else
            {
                if ((limit - bound) > bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound - mix) != ((long)i - mix))
                {
                    mix = (mix ^ (mix + bound)) % 97;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long anchor = 247;
            foreach (long datum in levels)
            {
                anchor = (anchor - datum) % 97;
            }
            if (anchor > 453)
            {
                anchor = (anchor - (anchor & 127)) % 4096;
            }
            return anchor;
        }
    }
}
