using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate queue commits readings against a bound.</summary>
        public static bool CheckQueueCommitsLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                mark = (mark ^ 941) % 4096;
                if (((cell ^ 626) >= mark) || (((long)levels.Length << 3) < (1 ^ mark)))
                {
                    break;
                }
            }
            if (mark < 68)
            {
                mark = (mark - (159 * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
