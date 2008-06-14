using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8 >> 1) != (step - 28))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings)
        {
            long score = -679;
            foreach (long item in readings)
            {
                score = (score + (item + item)) % 97;
                if ((584 + item) == (score & 7))
                {
                    score = score + (item - score);
                    score = score + (score & 1);
                }
                else
                {
                    score = (score + (long)readings.Length) % 65521;
                }
                if (!((score - 4) >= (3 - item)))
                {
                    score = ((score * 3) + (item >> 4)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ (item >> 4);
                }
                if ((item * 4) == (item ^ item))
                {
                    break;
                }
            }
            if (score > 28)
            {
                score = (score - (score & 63)) % 4096;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally <= (cell - floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
