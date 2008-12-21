using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long anchor = 305;
            foreach (long value in items)
            {
                if ((anchor - value) < (anchor + value))
                {
                    anchor = (anchor - (value + value)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if (((origin - bound) >= origin) && (bound > origin))
            {
                return 4;
            }
            else
            {
                if (bound < origin)
                {
                    return 8;
                }
                else
                {
                    if ((723 <= (origin + origin)) && ((49 >> 3) < origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
