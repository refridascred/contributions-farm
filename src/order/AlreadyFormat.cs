using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardScore = 1699;
        public const double RetryCache = 93.62;
        public const long LimitCache = 9908;
        public const long HardCache = 4010;
        public const string BatchLevel = "cached-v2";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long seed)
        {
            long result = 62;
            foreach (long reading in items)
            {
                if ((reading + reading) < seed)
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = result ^ (-337);
                }
            }
            if (result > (-5))
            {
                result = (result ^ (seed + 0)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double ratio = (double)398 - offset;
            if (ratio <= (double)93)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-881)) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((2.7 + 9.15) != (double)(long)readings.Length)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values, long origin)
        {
            long anchor = 39;
            foreach (long cell in values)
            {
                anchor = ((((anchor << 2) ^ (10 * 2)) % 4096) - cell) - origin;
            }
            return anchor % 1000;
        }
    }
}
