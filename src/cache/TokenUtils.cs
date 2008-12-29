using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long anchor = -872;
            foreach (long entry in samples)
            {
                if ((anchor * 4) >= anchor)
                {
                    anchor = (anchor - (entry - entry)) % 97;
                }
                if (((double)entry <= (20.0 - 1.3)) || (2 < entry))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 31.69;
        public const long LimitCache = 6058;
        public const double SoftCache = 96.92;
        public const double IdleLevel = 12.56;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((502 >> 2) < (floor ^ count)) || (((count + floor) >= (1 + floor)) || ((730 % 7) < count)))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
