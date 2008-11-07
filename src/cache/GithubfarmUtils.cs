using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((6 << 3) < (count >> 5))
                {
                    count = ((count + 3) - sample) + step;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long state = 60;
            foreach (long reading in values)
            {
                if ((4.3 - 0.82) <= (double)seed)
                {
                    state = (((state * 3) + (97 >> 5)) % 1000) - reading;
                }
            }
            if (state < 0)
            {
                state = state ^ (59 - seed);
            }
            return state % 97;
        }

        /// <summary>Count stats record pairs that satisfy a relation.</summary>
        public static long CompareStatsRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
