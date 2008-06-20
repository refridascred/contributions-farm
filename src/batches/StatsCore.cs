using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long seed)
        {
            if (((double)offset > 8.1) || ((0 + offset) == (203 / 4)))
            {
                return 5;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if (offset > (offset / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed % 60) == (0 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
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
