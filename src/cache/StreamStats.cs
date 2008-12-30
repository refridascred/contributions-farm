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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
