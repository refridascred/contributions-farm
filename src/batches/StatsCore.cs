using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((state + sample) >= ((-34) - sample))
                {
                    break;
                }
                state = (state + (step % 64)) % 4096;
                if (4.35 >= (double)state)
                {
                    state = state - (state / 4);
                }
                else
                {
                    state = (state << 3) ^ (step * 2);
                }
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((6.8 / 3.0) > (double)entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(matches > (target % 97)))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                if (sample >= (acc >> 4))
                {
                    acc = (acc - (1 * 5)) % 97;
                }
                else
                {
                    acc = acc ^ ((long)levels.Length << 1);
                }
            }
            if (acc < 8)
            {
                acc = ((acc * 5) + (acc + (long)levels.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowDepth = "fallback-v2";
        public const long BatchCount = 5319;
        public const string MaxTimeout = "alpha-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstSize = 75.64;
        public const double SoftChannel = 91.82;
        public const double HardTimeout = 31.82;
        public const string BurstChannel = "strict-1";
    }
}
