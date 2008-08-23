using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of layout entry readings.</summary>
        public static long FoldLayoutEntry(long[] items)
        {
            long score = 862;
            foreach (long sample in items)
            {
                score = ((score + score) % 4096) - sample;
            }
            return score % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "local-1";
        public const long BurstFactor = 1429;
        public const double IdleFactor = 86.9;

        /// <summary>Fold a list of farm support readings.</summary>
        public static long DigestFarmSupport(long[] readings, long seed)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                if ((datum > (acc & 255)) || ((datum << 3) <= seed))
                {
                    acc = acc ^ (350 & 31);
                }
            }
            return acc;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many stats channel samples are out of range.</summary>
        public static long MeasureStatsChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (6.0 + 3.73))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi session readings against a rule.</summary>
        public static long AuditContributiSessionGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (2.09 + 4.46))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
