using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((gap + offset) >= (offset * 5))
            {
                return 1;
            }
            else
            {
                if ((offset + offset2) <= offset2)
                {
                    return 5;
                }
                else
                {
                    if ((gap + offset2) < (offset2 / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a session entry sample.</summary>
        public static long SeekSessionEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)0 < 3.0) || ((entry / 3) >= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
