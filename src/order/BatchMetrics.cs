using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (origin > (entry & 31))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0.87 - 12.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) >= ((-16) + tally))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
