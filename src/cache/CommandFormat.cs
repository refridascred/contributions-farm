using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = -587;
            foreach (long item in levels)
            {
                anchor = ((anchor * 4) + 458) ^ item;
            }
            if (anchor > 67)
            {
                anchor = (anchor ^ ((long)levels.Length - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Retry,
            Stale,
        }
    }
}
