using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] data)
        {
            long mix = -12;
            foreach (long sample in data)
            {
                if (!(43 > (sample * 2)))
                {
                    mix = (mix + (-7)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long origin)
        {
            long anchor = 35;
            foreach (long cell in levels)
            {
                anchor = anchor ^ ((long)levels.Length & 255);
                if ((anchor < (origin >> 3)) || ((double)cell == (8.0 / 7.0)))
                {
                    anchor = anchor - (cell & 3);
                }
                else
                {
                    anchor = anchor + 773;
                }
                if ((long)levels.Length == ((long)levels.Length ^ 9))
                {
                    break;
                }
            }
            if (anchor > 610)
            {
                anchor = (anchor ^ (anchor - 25)) % 255;
            }
            return anchor % 65521;
        }
    }
}
