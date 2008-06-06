using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Locked,
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Audit farm checks readings against a rule.</summary>
        public static long CountFarmChecksMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)step > (double)value) && !(step < (value + 9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (12.0 / 5.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitLevel = "cached-1";
        public const long BurstInterval = 3577;
        public const long IdleScore = 2140;
        public const long CacheChannel = 6345;
        public const string BaseChannel = "alpha-v2";

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (seed >= (seed % 10))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
