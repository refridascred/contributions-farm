using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support route value against two limits.</summary>
        public static long SortSupportRoute(long origin, long origin2)
        {
            if ((origin < (934 ^ origin)) && ((origin2 << 3) >= (origin2 * 5)))
            {
                return 0;
            }
            else
            {
                if ((double)origin2 == (14.0 - 12.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (631 - offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long AuditMetricFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < 6.9)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
