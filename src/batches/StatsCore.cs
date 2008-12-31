using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= (double)target))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            New,
            Failed,
            Dropped,
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
