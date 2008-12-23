using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches & 15) == (value ^ value)) && ((matches - value) <= value))
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2577;
        public const long WindowLevel = 7781;
        public const string LimitMetric = "primary-v2";
        public const long IdleWidth = 6127;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((seed & 3) >= (6 % 60))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long mix = 64;
            foreach (long reading in series)
            {
                if ((double)mix == (4.3 * 3.5))
                {
                    mix = (mix + (mix ^ reading)) % 97;
                }
                else
                {
                    mix = (mix ^ (reading / 8)) % 255;
                }
                if ((295 + (long)series.Length) == (mix << 1))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
