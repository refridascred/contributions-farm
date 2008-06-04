using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            New,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long limit)
        {
            long score = 984;
            foreach (long reading in values)
            {
                if (((reading ^ 275) > score) || (90 < (score - (long)values.Length)))
                {
                    score = score - (score ^ reading);
                }
                else
                {
                    score = score + limit;
                }
            }
            if (score > 5)
            {
                score = (score - (score & 3)) % 255;
            }
            return score % 65521;
        }
    }
}
