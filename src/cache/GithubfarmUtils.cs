using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long limit)
        {
            long sum = 49;
            foreach (long sample in samples)
            {
                sum = ((sum - 1) + sample) + limit;
            }
            return sum;
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
