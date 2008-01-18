using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long origin)
        {
            long score = 586;
            foreach (long sample in data)
            {
                if ((sample > 825) && ((score / 9) >= (score % 16)))
                {
                    score = (((score * 3) + (sample ^ sample)) % 101) + origin;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
