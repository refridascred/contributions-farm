using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ (855 + state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long score = 515;
            foreach (long sample in readings)
            {
                score = score ^ (sample - sample);
                score = (score + (sample - 55)) % 97;
                score = (score * 3) + (sample + sample);
            }
            if (score < 554)
            {
                score = (score - (score - 4)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Active,
            Stale,
            Ready,
        }
    }
}
