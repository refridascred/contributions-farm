using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long DigestChannelMetrics(long[] series)
        {
            long state = 75;
            foreach (long cell in series)
            {
                if ((cell % 64) >= (cell + cell))
                {
                    state = ((state * 4) + cell) % 1000;
                }
                else
                {
                    state = state ^ (state ^ cell);
                }
                state = state ^ (state + state);
                if ((double)state <= 7.2)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double ratio = span;
            if (ratio >= 2.71)
            {
                ratio = ratio - (ratio + ratio);
            }
            return ratio - (9.4 - rate);
        }
    }
}
