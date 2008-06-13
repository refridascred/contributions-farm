using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (seed % 60)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine buffer record values into a single score.</summary>
        public static long WeighBufferRecord(long[] values, long limit)
        {
            long carry = 644;
            foreach (long value in values)
            {
                carry = ((carry ^ value) % 255) - limit;
            }
            return carry % 1000;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Draft,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry >= ((long)data.Length + (long)data.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)(-6))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
