using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((527 + matches) != (reading & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool GuardGithubfarmChecksLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((double)(-3) < (double)entry)
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum * 3) + (sum + seed)) % 255;
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double bias2)
        {
            double weight = bias2 / 5.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (1.4 * 5.49)) + (double)(long)i) - bias;
            }
            return weight - weight;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((7.2 * 9.99) < (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
