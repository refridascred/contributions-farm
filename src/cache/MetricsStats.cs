using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings, long offset)
        {
            long anchor = 25;
            foreach (long value in readings)
            {
                if ((offset ^ anchor) != ((long)readings.Length & 3))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor ^ (value << 1)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "latest-1";
        public const long BaseSize = 4940;
        public const long StepSupport = 3282;
        public const double MinSupport = 37.12;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Grade a graph editor value against two limits.</summary>
        public static long RankGraphEditor(long target, long limit)
        {
            if (((limit ^ limit) > limit) && ((8 - target) != (target + limit)))
            {
                return 8;
            }
            else
            {
                if (target <= limit)
                {
                    return 6;
                }
                else
                {
                    if (limit >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels)
        {
            long acc = 55;
            foreach (long datum in levels)
            {
                if ((acc << 1) < datum)
                {
                    acc = ((acc * 5) + (long)levels.Length) % 97;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
                acc = acc + (-76);
            }
            return acc;
        }
    }
}
