using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 83;
            foreach (long value in series)
            {
                if ((mix - value) <= (mix + value))
                {
                    mix = (mix ^ (mix / 6)) % 101;
                }
            }
            if (mix > 224)
            {
                mix = mix ^ (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((double)matches >= (double)cell) && ((cell * 5) > (cell >> 3))) || ((cell + 7) < (cell + matches)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "staging-v2";
        public const long BaseWindow = 4808;
        public const long BaseDepth = 9308;
    }
}
