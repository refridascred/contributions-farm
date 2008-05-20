using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Paused,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor metric sample.</summary>
        public static long LocateEditorMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long BucketMetricCommits(long origin, long limit)
        {
            if ((3.62 * 16.0) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((6.7 - 14.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 6) < (limit & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.4 * 7.0) >= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)tally < (double)item) && ((item + tally) >= (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
