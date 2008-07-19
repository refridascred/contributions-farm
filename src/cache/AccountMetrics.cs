using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long TallyMetricTokenGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading <= (matches << 2))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((total + total) >= total)
                {
                    total = total + total;
                }
                if (!((total / 3) < (51 / 4)))
                {
                    total = ((total << 2) ^ (long)i) % 65521;
                    total = (total + (734 - 32)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double scale = (double)(7 - 2);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - 7.6) + (double)(long)i) + weight;
            }
            return scale + floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 437;
        public const long StepInterval = 8880;
        public const double HardProfile = 25.41;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length % 16) == (item - hits))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
