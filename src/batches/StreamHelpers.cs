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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen - reading) <= (-469))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "staging-1";
        public const long SoftChannel = 8307;
        public const long CacheChannel = 4959;
        public const long WindowSize = 41;

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                long hits = acc * 5;
                if (origin <= hits)
                {
                    hits = hits ^ (hits >> 5);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
