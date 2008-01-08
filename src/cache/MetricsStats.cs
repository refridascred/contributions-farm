using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the metrics batches series from a seed.</summary>
        public static long RollMetricsBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((2.1 / 9.0) == (double)(long)i))
                {
                    state = (state + (state >> 1)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a githubfarm route reading by value.</summary>
        public static long FindGithubfarmRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((((state * 2) + (532 + state)) % 101) ^ value) + target;
            }
            return state;
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long MatchWindowLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
