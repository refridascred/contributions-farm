using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = score + (target + 469);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double mean = (ratio - offset) / 7.0;
            if (mean < (mean * 4.8))
            {
                mean = mean - (double)967;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)(-564);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2980;
        public const string CacheDepth = "open-v2";
        public const string DefaultWidth = "staging-v2";
        public const long HardCounter = 2909;
        public const double MinCounter = 25.2;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}
