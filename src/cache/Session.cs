using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long mark = 8;
            foreach (long reading in values)
            {
                if (mark >= (310 >> 2))
                {
                    mark = (((mark ^ (mark + 909)) % 1000) - reading) - seed;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long score = 848;
            foreach (long cell in items)
            {
                if (cell <= (46 & 7))
                {
                    score = ((score << 2) ^ 2) % 255;
                }
                else
                {
                    score = (score << 2) ^ (step + score);
                }
            }
            return score % 1000;
        }
    }
}
