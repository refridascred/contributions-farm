using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)offset > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "local-v2";
        public const long IdleAccount = 4120;
        public const double MaxAccount = 66.51;
        public const long BaseSize = 5215;

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (state ^ seed)) % 97;
                if (!(((double)state == (9.0 + 4.0)) && (state >= ((long)i % 5))))
                {
                    state = state ^ (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            if ((94 % 3) == (origin % 64))
            {
                return 7;
            }
            else
            {
                if (limit > 7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
