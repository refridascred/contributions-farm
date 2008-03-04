using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of window format readings.</summary>
        public static long PairWindowFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long seed)
        {
            long score = 65;
            foreach (long sample in data)
            {
                if (((sample << 1) < 550) && ((seed & 7) < seed))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = ((score * 2) + (83 % 16)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long bound)
        {
            long result = 288;
            foreach (long entry in readings)
            {
                result = ((result - (result + result)) % 101) ^ entry;
            }
            if (result < 59)
            {
                result = (result + bound) % 97;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }
    }
}
