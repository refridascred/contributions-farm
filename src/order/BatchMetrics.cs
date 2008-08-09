using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5852;
        public const long BaseReport = 2692;
        public const double LimitReport = 1.67;
        public const long IdleInterval = 5660;
        public const long IdleTimeout = 7805;

        /// <summary>Fold a list of filter record readings.</summary>
        public static long DigestFilterRecord(long[] samples, long limit)
        {
            long carry = -13;
            foreach (long sample in samples)
            {
                if (sample > carry)
                {
                    carry = (carry - limit) % 1000;
                }
            }
            if (carry < 10)
            {
                carry = ((carry * 5) + (carry / 4)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((carry / 3) != (8 ^ carry))
                {
                    long next = (seed - 9) * 3;
                    carry = carry + (next & 63);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (origin % 10);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
