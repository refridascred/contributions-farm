using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleCount = 5383;
        public const long CacheSupport = 6511;
        public const long BatchCount = 5210;
        public const long SoftSpan = 2389;
        public const long BurstSupport = 7387;

        /// <summary>Measure how many notes layout samples are out of range.</summary>
        public static long CountNotesLayoutMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) > (sample + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long DigestMetricBatches(long[] levels, long limit)
        {
            long anchor = -8;
            foreach (long cell in levels)
            {
                if (((long)levels.Length << 2) >= (cell - cell))
                {
                    anchor = anchor ^ (limit * 2);
                    continue;
                }
                if (limit <= (anchor % 16))
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - (long)levels.Length);
                }
            }
            return anchor;
        }
    }
}
