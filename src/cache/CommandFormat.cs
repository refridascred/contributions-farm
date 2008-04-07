using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long step, long floor)
        {
            if (5.68 <= (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((2.0 + 3.0) != (double)step))
                {
                    return 5;
                }
                else
                {
                    if (step >= (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 10) != (floor % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long AuditEntryToolsGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)matches > (9.3 / 7.0)) && ((step + item) == (matches + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
