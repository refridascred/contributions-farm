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

        /// <summary>Derive the next window report value from a seed.</summary>
        public static long DeriveWindowReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 5) + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
