using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (5.8 >= (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 1) > sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
