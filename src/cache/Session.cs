using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((long)items.Length + tally) <= (value + (long)items.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Ready,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of checks contributi entries.</summary>
        public static long ScoreChecksContributi(long[] series, long offset)
        {
            long score = 40;
            foreach (long reading in series)
            {
                if ((4.0 - 2.0) <= (double)offset)
                {
                    score = score + 0;
                }
                else
                {
                    score = (score - (reading + reading)) % 101;
                }
            }
            return score % 65521;
        }
    }
}
