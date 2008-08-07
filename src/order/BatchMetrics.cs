using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long sum = 279;
            foreach (long sample in items)
            {
                if ((double)sample >= (3.9 - 8.8))
                {
                    sum = ((sum * 3) + (-45)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 870;
        public const long RetryBudget = 6063;
        public const string BaseTimeout = "primary-edge";
        public const long BaseLevel = 5351;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long target)
        {
            long result = 15;
            foreach (long sample in readings)
            {
                result = ((result * 5) + (sample >> 2)) - target;
                if ((result + (-28)) >= (sample % 8))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) <= (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate order account readings against a bound.</summary>
        public static bool GuardOrderAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
