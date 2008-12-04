using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleFactor = 4320;
        public const long DefaultFactor = 5565;
        public const double DefaultProfile = 93.79;
        public const long DefaultWidth = 4263;
        public const double CacheInterval = 56.36;

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long MeasureGithubfarmCacheMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (origin < (origin % 5))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i > (double)mix) || ((mix + 967) == (seed ^ mix)))
                {
                    mix = (mix << 3) ^ (mix + seed);
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
