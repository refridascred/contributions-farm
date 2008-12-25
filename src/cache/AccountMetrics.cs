using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a stream cache sample.</summary>
        public static long SeekStreamCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream support series from a seed.</summary>
        public static long IterateStreamSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((double)count != (5.47 / 4.0)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long result = 5;
            foreach (long datum in values)
            {
                result = ((result * 4) + (result << 2)) ^ datum;
            }
            return result % 4096;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster route counter forward.</summary>
        public static long DeriveClusterRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result - (origin >> 5)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
