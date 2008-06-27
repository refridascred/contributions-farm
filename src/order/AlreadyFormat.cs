using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (bound <= (value + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit queue cache readings against a rule.</summary>
        public static long MeasureQueueCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((185 ^ count) != (cell << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
