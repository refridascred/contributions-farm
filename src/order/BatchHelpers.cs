using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((limit - item) > (limit >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long mix = 10;
            foreach (long reading in values)
            {
                if (!((mix - mix) <= (mix ^ reading)))
                {
                    mix = mix - 448;
                }
                if ((mix & 1) > (385 - 566))
                {
                    break;
                }
            }
            if (mix > 79)
            {
                mix = ((mix * 3) + offset) % 255;
            }
            return mix;
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long AuditGithubfarmBufferGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((matches >> 1) <= sample) && ((51 + matches) != (5 >> 1))) && ((sample + 3) < (matches % 64)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }
    }
}
