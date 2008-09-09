using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                anchor = anchor + (anchor - anchor);
                if ((double)sample <= (6.0 - 4.11))
                {
                    anchor = (anchor + (long)levels.Length) % 97;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stream command value against two limits.</summary>
        public static long GradeStreamCommand(long seed, long step)
        {
            long delta = seed + step;
            if ((double)step >= (6.9 + 2.22))
            {
                return 6;
            }
            else
            {
                if ((seed / 7) >= (23 >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 3) != (seed << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every checks channel entry stays within the limit.</summary>
        public static bool ValidateChecksChannelLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
