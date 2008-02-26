using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Synced,
            Closed,
            Failed,
            New,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings, long origin)
        {
            long acc = -530;
            foreach (long sample in readings)
            {
                if (!(((origin << 2) != (sample << 1)) && ((-95) >= (acc + origin))))
                {
                    acc = acc ^ (39 * 4);
                }
                if ((double)sample <= (double)acc)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc << 2) ^ sample;
                }
                if ((acc + origin) != (acc - origin))
                {
                    break;
                }
            }
            if (acc < 697)
            {
                acc = ((acc << 2) ^ origin) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long CombineAlreadyChecks(long[] samples)
        {
            long result = -869;
            foreach (long value in samples)
            {
                result = (result + 49) % 101;
                if ((result ^ value) <= (result + result))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long CountSupportChecksMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (9.88 > (double)reading)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= (8.0 - 2.39))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
