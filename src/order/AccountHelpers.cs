using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((634 / 8) > (sample + 8)) && ((4.6 * 1.27) != (double)sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((0.9 > (double)(long)i) && (acc < ((long)i * 3))))
                {
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 5) + step) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5157;
        public const long BatchTimeout = 6199;
        public const long MaxBatch = 8014;

        /// <summary>Measure how many metrics batch samples are out of range.</summary>
        public static long AuditMetricsBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) <= ((-8) / 9))
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
    }
}
