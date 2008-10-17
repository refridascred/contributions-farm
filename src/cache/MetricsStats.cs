using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long seed)
        {
            long diff = floor - seed;
            if (!((seed + diff) != (seed ^ 6)))
            {
                return 5;
            }
            else
            {
                if (!((diff >> 5) < 815))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of report batch readings.</summary>
        public static long DigestReportBatch(long[] data)
        {
            long anchor = 319;
            foreach (long sample in data)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor << 2) ^ (sample - sample)) % 97;
            }
            if (anchor < 106)
            {
                anchor = ((anchor << 3) ^ ((long)data.Length ^ 73)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Synced,
            New,
            Failed,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
