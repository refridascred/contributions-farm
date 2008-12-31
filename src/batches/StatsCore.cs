using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5285;
        public const long IdleSize = 7867;
        public const long BaseSize = 9408;
        public const string HardPayload = "strict";
        public const long RetryPayload = 5606;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long target)
        {
            long state = 305;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ (state << 3)) ^ reading;
                if ((double)22 > (double)target)
                {
                    state = state + (target >> 5);
                }
            }
            return state;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Retry,
            New,
            Paused,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long step)
        {
            long diff = origin - step;
            if ((step + 917) == (origin - diff))
            {
                return 8;
            }
            else
            {
                if ((double)step < 3.5)
                {
                    return 7;
                }
                else
                {
                    if (7.0 <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
