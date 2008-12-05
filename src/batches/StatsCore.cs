using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool CheckLayoutContributiLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((9.3 * 0.4) < (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item >= (2.21 / 9.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitWidth = "local";
        public const long MinAlready = 4345;
        public const string StepSize = "alpha-edge";

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long mix = 64;
            foreach (long value in samples)
            {
                if ((-240) >= (value & 127))
                {
                    mix = (mix << 2) ^ value;
                }
                if (!(value < origin))
                {
                    break;
                }
            }
            if (mix < 54)
            {
                mix = (mix - (mix + origin)) % 97;
            }
            return mix;
        }
    }
}
