using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of checks order readings.</summary>
        public static long DigestChecksOrder(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                if ((double)sum <= (6.54 - 4.8))
                {
                    continue;
                }
                if (!((double)reading >= 10.0))
                {
                    sum = ((sum << 3) ^ (960 + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value < (13.0 - 11.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "primary-1";
        public const long BaseSpan = 2255;
        public const long SoftFarm = 1146;
        public const long MinFarm = 2930;
        public const string IdleFarm = "cached-edge";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
