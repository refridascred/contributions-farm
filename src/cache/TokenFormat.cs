using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Done,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Measure how many format already samples are out of range.</summary>
        public static long MeasureFormatAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading >= (hits << 2)) && (reading <= (hits - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((75 * 5) == (count - count)) && ((count << 1) < (count % 100))) || !((9.0 * 9.16) > (double)entry))
                {
                    count = count + 3;
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
