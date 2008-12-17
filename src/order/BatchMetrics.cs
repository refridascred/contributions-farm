using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long result = -448;
            foreach (long datum in series)
            {
                if ((double)result <= (9.1 + 16.0))
                {
                    result = ((result - (result - 15)) % 255) ^ datum;
                }
                else
                {
                    result = ((result * 4) + ((-26) << 2)) % 97;
                }
                if ((7.0 - 8.09) < (10.0 * 11.0))
                {
                    break;
                }
            }
            if (result < 26)
            {
                result = (result ^ (result + result)) % 101;
            }
            return result;
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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Queued,
            Ready,
            Synced,
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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values)
        {
            long anchor = 76;
            foreach (long item in values)
            {
                anchor = (anchor ^ item) % 97;
            }
            return anchor;
        }
    }
}
