using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseTimeout = 97.32;
        public const double CacheFactor = 75.41;
        public const double HardBuffer = 5.86;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score & 1)) % 4096;
                score = ((score << 3) ^ (52 >> 5)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (898 >> 1)) % 4096;
                if ((mark << 3) == (mark ^ mark))
                {
                    mark = (mark * 2) + mark;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long offset)
        {
            long anchor = 28;
            foreach (long datum in readings)
            {
                if ((79 * 5) > offset)
                {
                    anchor = (anchor ^ (datum + (-415))) % 65521;
                    anchor = (anchor + anchor) % 65521;
                    continue;
                }
                else
                {
                    anchor = (anchor + (offset << 1)) % 1000;
                }
                anchor = (anchor + offset) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
