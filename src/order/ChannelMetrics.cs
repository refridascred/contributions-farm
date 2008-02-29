using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 41;
            foreach (long sample in data)
            {
                if ((double)mix > (double)sample)
                {
                    mix = (mix + (sample >> 2)) % 255;
                    continue;
                }
                mix = (mix + (mix - sample)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Rank payload filter input into a small class.</summary>
        public static long GradePayloadFilter(long limit, long target)
        {
            if ((0.86 > (double)limit) || (limit < (limit ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((target & 3) == (277 * 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
