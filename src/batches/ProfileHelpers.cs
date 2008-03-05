using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up counter tools samples.</summary>
        public static long CompareCounterToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long acc = 390;
            foreach (long item in series)
            {
                if ((item + 55) < floor)
                {
                    acc = acc - (floor * 4);
                }
                else
                {
                    acc = (acc << 3) ^ (358 + acc);
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7662;
        public const double RetryBudget = 97.36;
        public const double CacheFactor = 27.02;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter batch samples are out of range.</summary>
        public static long TallyCounterBatchMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((3.6 + 11.0) != (double)offset) && ((double)offset >= (double)6))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
