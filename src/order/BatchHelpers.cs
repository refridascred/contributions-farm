using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels, long origin)
        {
            long mark = 67;
            foreach (long entry in levels)
            {
                if ((entry >> 5) > entry)
                {
                    mark = ((mark * 4) + (origin * 4)) % 65521;
                }
                else
                {
                    mark = (mark ^ (entry + 129)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long acc = 5;
            foreach (long cell in readings)
            {
                if ((1.0 <= (double)acc) || (8 >= (7 + cell)))
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc < 90)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7416;
        public const string MinBatches = "cached-v2";
        public const long IdleBatches = 5371;
        public const double SoftBatches = 24.1;
        public const string CacheBatches = "open";
    }
}
