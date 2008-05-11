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

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long anchor = -37;
            foreach (long entry in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (anchor / 4)) % 101) + (long)i;
                    anchor = anchor + (entry - entry);
                }
                if ((672 >> 3) <= (anchor >> 3))
                {
                    anchor = (anchor - entry) % 97;
                }
                if ((double)entry > (1.7 - 10.0))
                {
                    anchor = (anchor ^ 292) % 4096;
                }
            }
            if (anchor < 81)
            {
                anchor = anchor - (3 >> 4);
            }
            return anchor % 97;
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
