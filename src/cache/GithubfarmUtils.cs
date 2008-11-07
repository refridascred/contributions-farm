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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
