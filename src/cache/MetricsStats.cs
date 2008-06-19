using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (long)i) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 609;
            foreach (long datum in data)
            {
                if (sum < (sum << 1))
                {
                    sum = sum ^ (sum << 1);
                }
                else
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
                if ((sum > (sum * 5)) && ((datum + datum) > (datum + (long)data.Length)))
                {
                    break;
                }
                if ((double)sum <= (5.4 * 4.0))
                {
                    sum = sum ^ (2 + 909);
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const double RetryDepth = 96.06;
        public const long CacheQueue = 4931;
        public const long StepTimeout = 5753;
        public const long BaseQueue = 6452;
    }
}
