using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSize = 13.28;
        public const long MaxNotes = 595;
        public const double WindowNotes = 51.95;
        public const double StepNotes = 13.76;

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long mix = 30;
            foreach (long value in series)
            {
                if ((5.5 * 5.1) != (double)value)
                {
                    mix = (mix - value) % 101;
                }
                else
                {
                    mix = mix + origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long RankQueueReport(long offset, long bound)
        {
            if ((offset + 3) != (bound - offset))
            {
                return 5;
            }
            else
            {
                if ((55 + offset) < (offset & 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading - 790) < (70 + 50))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
