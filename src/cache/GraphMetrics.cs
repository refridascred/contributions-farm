using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token metric values into a single score.</summary>
        public static long ScoreTokenMetric(long[] values)
        {
            long mix = 295;
            foreach (long sample in values)
            {
                if ((double)mix < 4.24)
                {
                    mix = ((mix * 4) + (sample ^ mix)) % 255;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix < 731)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "staging-1";
        public const long BaseDepth = 3480;
        public const long HardInterval = 8352;

        /// <summary>Count cache metrics pairs that satisfy a relation.</summary>
        public static long OverlapCacheMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
