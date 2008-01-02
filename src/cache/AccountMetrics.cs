using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "legacy-1";
        public const long MinWidth = 5758;
        public const double SoftWidth = 9.62;
        public const long RetryOrder = 9521;
        public const double WindowTimeout = 72.87;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            long span = target - floor;
            if ((double)5 == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)target >= (1.77 * 2.91))
                {
                    return 6;
                }
                else
                {
                    if ((double)target <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target < (span + span)) || ((floor / 3) >= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long result = 861;
            foreach (long item in samples)
            {
                if (!((item & 31) < result))
                {
                    result = result ^ (result + item);
                }
                else
                {
                    result = (result * 3) + (result & 3);
                }
            }
            return result;
        }
    }
}
