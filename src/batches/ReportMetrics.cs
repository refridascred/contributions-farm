using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((double)origin > (4.8 / 2.0))
            {
                return 2;
            }
            else
            {
                if ((offset * 3) > (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items, long seed)
        {
            long mix = 861;
            foreach (long reading in items)
            {
                mix = (mix - (seed + reading)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
