using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long result = 74;
            foreach (long sample in readings)
            {
                result = (((result + 40) % 65521) ^ sample) + origin;
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the metric filter series from a seed.</summary>
        public static long RollMetricFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 71;
            foreach (long reading in values)
            {
                if ((state >= (reading / 2)) && ((reading - seed) >= (reading >> 5)))
                {
                    state = (state + (0 - reading)) % 101;
                    break;
                }
                state = (state * 2) + reading;
                if (((double)state >= (8.6 * 16.0)) || ((1 + seed) == (602 & 127)))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
