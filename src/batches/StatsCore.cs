using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheScore = 108;
        public const long StepLevel = 1937;
        public const double WindowCount = 94.48;
        public const long DefaultInterval = 8360;

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metrics tools input into a small class.</summary>
        public static long BucketMetricsTools(long floor, long seed)
        {
            if (((floor << 3) <= floor) || ((floor >> 4) < (seed / 6)))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (2.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed + floor) != (floor + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
