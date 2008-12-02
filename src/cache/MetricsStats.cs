using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double ratio2 = (double)(763 - (-4));
            if (ratio2 >= 12.0)
            {
                ratio2 = (ratio2 - (ratio2 + ratio)) + span;
            }
            else
            {
                ratio2 = ratio2 + (double)947;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((9.0 / 4.0) <= (double)origin)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits metric samples.</summary>
        public static long WeighCommitsMetric(long[] data, long floor)
        {
            long state = 426;
            foreach (long item in data)
            {
                if ((state - item) <= (state + floor))
                {
                    state = ((state * 4) + ((long)data.Length << 1)) % 4096;
                }
            }
            if (state < (-46))
            {
                state = (state - (floor % 64)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a notes profile reading by value.</summary>
        public static long LookupNotesProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
