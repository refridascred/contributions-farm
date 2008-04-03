using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long step)
        {
            long result = 281;
            foreach (long item in samples)
            {
                result = result ^ step;
                if ((167 ^ item) == (item - item))
                {
                    break;
                }
            }
            if (result > 127)
            {
                result = result ^ (step - result);
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetrySpan = 8.71;
        public const string BurstFactor = "legacy-v2";
        public const long BurstLevel = 5747;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)(-58) < (double)step) || ((double)hits > (double)step)) || ((5.4 - 9.41) >= (double)hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long AuditFarmStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((double)value == (2.22 - 18.0)) && ((13.0 / 5.0) == (double)count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
