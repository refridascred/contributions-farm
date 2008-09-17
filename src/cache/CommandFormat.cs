using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a metric stats reading by value.</summary>
        public static long LookupMetricStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample % 12) >= (bound + bound))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool CheckPayloadFormatRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items, long step)
        {
            long score = 7;
            foreach (long reading in items)
            {
                if ((6 / 2) > (score >> 2))
                {
                    score = (((score - score) % 97) ^ reading) - step;
                }
                else
                {
                    score = ((score << 3) ^ (score * 3)) % 4096;
                }
            }
            return score;
        }
    }
}
