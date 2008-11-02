using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long AuditMetricBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + seen) > (seen + seen))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
