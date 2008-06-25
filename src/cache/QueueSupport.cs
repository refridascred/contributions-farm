using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 798;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (result - datum))
                {
                    result = (result ^ result) % 4096;
                }
                if (((112 % 10) >= (result ^ datum)) && (result < (datum % 16)))
                {
                    result = result + ((long)levels.Length / 6);
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 43;
            foreach (long entry in series)
            {
                score = (score - (score & 1)) - entry;
                score = (score ^ score) % 1000;
                if ((674 - 26) > (score % 7))
                {
                    break;
                }
            }
            if (score > (-360))
            {
                score = score - (score & 255);
            }
            return score % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "staging";
        public const double SoftBudget = 47.72;
        public const long CacheChannel = 7596;
        public const long BurstChannel = 1310;
        public const long RetryFactor = 6773;
    }
}
