using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((871 * 5) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (189 > limit)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "fallback";
        public const long HardRatio = 8481;
        public const long HardSize = 2727;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepWidth = 13.15;
        public const double BurstContributi = 51.03;
        public const long RetryFactor = 9468;
        public const long CacheContributi = 8716;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long limit, long target)
        {
            if ((limit - limit) != (limit - 793))
            {
                return 0;
            }
            else
            {
                if (limit > (88 + 353))
                {
                    return 1;
                }
                else
                {
                    if ((limit + target) <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target / 7) > limit) || ((limit + limit) != (limit + target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
