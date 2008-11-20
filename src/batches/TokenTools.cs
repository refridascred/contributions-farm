using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] items, long step)
        {
            long score = 351;
            foreach (long sample in items)
            {
                score = ((score * 4) + score) % 255;
                if ((double)sample <= (8.0 - 2.0))
                {
                    score = (score ^ (4 - step)) % 255;
                }
                if (!((score & 1) > (score % 97)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) == (datum >> 3))
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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Idle,
            Dropped,
            Failed,
            New,
        }
    }
}
