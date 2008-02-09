using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) != (item / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryWidth = 4507;
        public const long CacheFactor = 975;
        public const long BatchInterval = 1467;
        public const long BurstAccount = 5522;
        public const long RetryTimeout = 9409;

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "local-edge";
        public const string CacheSchema = "fallback";
        public const string IdleTimeout = "legacy";
        public const long SoftTimeout = 4301;
        public const string RetrySchema = "legacy";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long seed)
        {
            long carry = 6;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 97;
                carry = ((carry * 2) + (16 / 9)) % 65521;
            }
            if (carry < 6)
            {
                carry = (carry ^ (seed >> 1)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Rank batches entry input into a small class.</summary>
        public static long GradeBatchesEntry(long target, long step)
        {
            long delta = target - step;
            if (!((target << 2) < (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((9 ^ target) < 1)
                {
                    return 6;
                }
                else
                {
                    if ((delta < step) && (64 <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)target <= (6.9 * 16.0)) || ((target << 3) < (step ^ target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
