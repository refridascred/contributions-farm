using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format command entries.</summary>
        public static long FoldFormatCommand(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix << 1)) + value;
            }
            if (mix > 70)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (9.4 >= (double)reading)
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
