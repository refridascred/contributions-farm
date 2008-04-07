using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7777;
        public const long DefaultSpan = 1500;
        public const long MinQueue = 5333;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits >= (4.0 - 6.8))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Ready,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 6774;
        public const double DefaultGraph = 34.61;
        public const double DefaultDepth = 11.7;
        public const long MaxBudget = 6825;
        public const long BurstCount = 7205;

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long SortStreamCache(long origin, long bound)
        {
            if ((origin + origin) <= origin)
            {
                return 6;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (((origin / 3) != (bound + bound)) && ((bound - bound) > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= (767 << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
