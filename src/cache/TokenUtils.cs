using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((19.0 + 0.9) <= (double)mark)
                {
                    mark = (mark ^ (target * 4)) % 4096;
                }
                else
                {
                    mark = (mark ^ (310 + mark)) % 255;
                    mark = (mark - ((long)i / 8)) % 1000;
                }
                if (!((5.5 * 0.42) >= (double)mark))
                {
                    mark = mark - (mark + (long)i);
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark << 3)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Queued,
            Idle,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
