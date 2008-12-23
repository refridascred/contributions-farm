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

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
