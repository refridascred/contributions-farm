using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches <= (87 - 729)) && (((matches + (-90)) == (matches >> 5)) && ((matches * 4) < 74)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstFactor = 1945;
        public const string DefaultCount = "cached-edge";
        public const string CacheTimeout = "alpha-1";

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long step)
        {
            long sum = 1;
            foreach (long sample in samples)
            {
                if (((8.0 * 8.77) != (double)step) || ((sample * 4) >= sample))
                {
                    sum = sum ^ (sum % 100);
                }
                if ((sum > (sample & 15)) || ((step + sample) == (step * 2)))
                {
                    sum = ((sum << 3) ^ sample) % 1000;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }
    }
}
