using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSize = 7676;
        public const string SoftInterval = "staging-edge";
        public const long HardToken = 1329;
        public const long IdleSpan = 9806;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 136;
        public const double CacheRatio = 4.32;
        public const long BatchBudget = 6517;
        public const long BurstSpan = 547;
        public const long MaxScore = 1695;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((target % 2) >= target)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long target)
        {
            if ((seed ^ target) > (target + target))
            {
                return 7;
            }
            else
            {
                if ((391 + seed) < (7 & 7))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed <= 16.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
