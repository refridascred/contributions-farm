using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = (result - (35 ^ bound)) % 65521;
                if ((bound << 3) > (bound ^ 45))
                {
                    result = (result ^ (bound + result)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = (weight * 6.71) + weight;
            if (mean > (mean * 1.6))
            {
                mean = mean - (bias / 4.0);
            }
            return mean - (double)221;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.9 / 6.0) < (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 2) > mix)
                {
                    mix = (mix ^ (mix << 2)) % 101;
                    mix = (mix + (origin << 3)) % 97;
                }
                long step = 359 ^ (mix + mix);
                if (!((mix + origin) >= step))
                {
                    mix = (mix ^ (mix << 3)) % 1000;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
