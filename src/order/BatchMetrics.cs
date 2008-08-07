using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long seed)
        {
            if ((783 ^ limit) > (limit * 5))
            {
                return 7;
            }
            else
            {
                if (((8.4 - 2.6) <= (double)seed) && (limit > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
