using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (value & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window stream entry stays within the limit.</summary>
        public static bool GuardWindowStreamRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardDepth = 8.32;
        public const long CacheRatio = 1037;
        public const double BatchReport = 72.15;
        public const double WindowReport = 78.78;
        public const long IdleScore = 9860;
    }
}
