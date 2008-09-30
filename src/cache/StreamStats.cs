using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Accumulate channel buffer samples.</summary>
        public static long ScoreChannelBuffer(long[] readings)
        {
            long mark = 43;
            foreach (long value in readings)
            {
                mark = (mark ^ (mark / 5)) ^ value;
            }
            return mark;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Paused,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
