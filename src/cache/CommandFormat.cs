using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (8.7 / 2.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank support window input into a small class.</summary>
        public static long ClassifySupportWindow(long target, long origin)
        {
            if ((target & 63) < (1 & 31))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (double)(-771))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                score = (score ^ (cell & 7)) % 65521;
                if (((double)score < (9.0 / 2.0)) && (cell <= (cell & 15)))
                {
                    score = (score ^ cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Idle,
            New,
        }
    }
}
