using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long CountEditorContributiGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - datum) >= seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((83 <= (reading ^ matches)) && ((reading ^ reading) != (matches + reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count profile already pairs that satisfy a relation.</summary>
        public static long MatchProfileAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank channel graph input into a small class.</summary>
        public static long SortChannelGraph(long origin, long seed)
        {
            if ((origin << 1) >= (origin % 2))
            {
                return 5;
            }
            else
            {
                if (!(3.7 > (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
