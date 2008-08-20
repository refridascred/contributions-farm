using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen << 1) <= (datum << 3)) && ((datum + seen) < (seen + datum)))
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

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "fallback-1";
        public const long LimitCount = 198;
        public const string HardWidth = "primary";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long origin, long offset)
        {
            long lane = origin + offset;
            if ((double)origin >= 0.9)
            {
                return 4;
            }
            else
            {
                if ((offset / 2) < (56 * 2))
                {
                    return 1;
                }
                else
                {
                    if (!((origin & 255) == (lane - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.26 - 7.8) != (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (7.7 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
