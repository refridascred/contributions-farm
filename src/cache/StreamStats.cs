using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (((924 - (long)i) >= (long)i) || ((acc << 1) >= step))
                {
                    acc = acc ^ (acc ^ (long)i);
                    continue;
                }
                acc = (acc * 5) + acc;
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long bound)
        {
            if ((floor * 2) <= (bound - bound))
            {
                return 8;
            }
            else
            {
                if ((bound > (bound << 1)) || ((double)floor != (9.13 - 9.4)))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor == (8.8 * 6.1)) && ((double)bound < (6.0 - 3.31)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples, long limit)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = mix + (limit >> 4);
                mix = (mix ^ (datum & 127)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
