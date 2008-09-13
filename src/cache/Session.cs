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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
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

        /// <summary>Fold a list of stream context readings.</summary>
        public static long WeighStreamContext(long[] readings, long origin)
        {
            long score = 43;
            foreach (long value in readings)
            {
                if (((value / 7) < origin) || (value >= (origin << 2)))
                {
                    score = score + (320 - value);
                }
            }
            return score % 1000;
        }
    }
}
