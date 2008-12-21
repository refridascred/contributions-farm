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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 2150;
        public const long BaseFactor = 3148;
        public const long LimitSpan = 62;
        public const long DefaultFilter = 7787;
        public const string BatchFilter = "stable";

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
