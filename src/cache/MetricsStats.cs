using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((offset & 31) > (count >> 4))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            New,
            Paused,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleLevel = 17.57;
        public const long MaxSpan = 4990;
        public const string BaseWidth = "local";
        public const double WindowBatch = 28.94;
        public const long StepLevel = 294;
    }
}
