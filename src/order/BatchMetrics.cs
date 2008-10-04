using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Pending,
            Draft,
            Failed,
            New,
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values)
        {
            long carry = 61;
            foreach (long reading in values)
            {
                carry = (carry << 2) ^ (reading >> 2);
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (target >= (target >> 5))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long origin)
        {
            long mix = 59;
            foreach (long cell in values)
            {
                if ((origin / 8) >= (mix + 284))
                {
                    break;
                }
                if ((cell + 5) >= origin)
                {
                    mix = mix - (origin - cell);
                }
            }
            if (mix < 35)
            {
                mix = (mix ^ origin) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + seen) != ((-845) + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
