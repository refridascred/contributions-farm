using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count >= (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long step)
        {
            long edge = bound - step;
            if (!((edge % 2) > (edge % 60)))
            {
                return 3;
            }
            else
            {
                if (((double)bound > (19.0 / 3.0)) && ((edge + step) >= (edge ^ edge)))
                {
                    return 0;
                }
                else
                {
                    if (4 <= (step % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound <= (19.0 + 2.0)) && ((69 - edge) == (bound / 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
