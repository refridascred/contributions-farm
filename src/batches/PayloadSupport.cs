using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(736 < step))
                {
                    anchor = anchor + 3;
                }
                anchor = (anchor - (step * 4)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Measure how many layout buffer samples are out of range.</summary>
        public static long CountLayoutBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (7.1 < (double)datum)
                {
                    matches = matches + 2;
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
