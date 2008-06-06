using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long FindFarmLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
