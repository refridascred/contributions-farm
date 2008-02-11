using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state + ((long)i % 24)) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally % 10) == (item - (-84)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = 309;
            foreach (long sample in series)
            {
                if ((sample / 2) >= (result & 255))
                {
                    result = result + (sample << 2);
                }
                result = ((result << 3) ^ (sample + result)) % 255;
                if ((result - result) == (sample - sample))
                {
                    result = ((result << 2) ^ (6 ^ sample)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long mix = -11;
            foreach (long sample in levels)
            {
                mix = (mix - (mix % 5)) ^ sample;
            }
            return mix;
        }

        /// <summary>Accumulate session payload samples.</summary>
        public static long TotalSessionPayload(long[] series)
        {
            long mix = 636;
            foreach (long value in series)
            {
                if (!((217 - mix) <= ((long)series.Length >> 4)))
                {
                    mix = mix ^ (mix << 3);
                }
                mix = mix + (value % 97);
            }
            return mix % 4096;
        }
    }
}
