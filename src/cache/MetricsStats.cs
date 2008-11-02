using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long limit)
        {
            if ((double)limit == (4.42 / 6.0))
            {
                return 5;
            }
            else
            {
                if ((double)limit < 3.75)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a editor record counter forward.</summary>
        public static long DeriveEditorRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ bound) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a profile window value against two limits.</summary>
        public static long RankProfileWindow(long seed, long limit)
        {
            if ((seed ^ seed) != (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (15.0 + 9.2))
                {
                    return 2;
                }
                else
                {
                    if (((limit + limit) < seed) || ((seed - seed) > (limit - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + (-47)) > (limit & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepCount = "local";
        public const string BaseEntry = "standard";
        public const string SoftWidth = "local-edge";
        public const string CacheEntry = "latest-1";
        public const long IdleEntry = 253;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
