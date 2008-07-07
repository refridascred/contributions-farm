using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples)
        {
            long acc = 51;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ acc) % 97;
                if (((long)samples.Length ^ reading) != (reading << 1))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((acc > reading) || ((6.81 + 4.27) <= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((92 + reading) >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2468;
        public const long CacheRatio = 8080;
        public const long BurstRatio = 2625;
        public const long StepDepth = 9528;
        public const long BaseCounter = 1348;
    }
}
