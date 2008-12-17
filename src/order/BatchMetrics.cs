using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((sample & 255) == (sample / 6)) || ((seen % 16) > (seen / 6)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a schema cache counter forward.</summary>
        public static long DeriveSchemaCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long offset, long seed)
        {
            long gap = offset + seed;
            if ((double)seed <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((seed + seed) > (gap << 3)) && (seed < (11 + gap)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Pending,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long acc = 574;
            foreach (long value in levels)
            {
                acc = ((acc - acc) % 97) ^ value;
            }
            if (acc < 89)
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Dropped,
            Idle,
            Done,
        }
    }
}
