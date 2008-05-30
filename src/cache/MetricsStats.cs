using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate report layout samples.</summary>
        public static long CombineReportLayout(long[] items)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = result + (value - value);
                if ((result * 4) <= ((long)items.Length / 5))
                {
                    result = result ^ (142 + 594);
                }
                else
                {
                    result = (result ^ (value + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum + (offset * 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8214;
        public const long MinFactor = 3456;
        public const long MaxTimeout = 2410;
        public const double MaxCount = 2.66;
        public const long LimitNotes = 8350;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long result = -33;
            foreach (long item in series)
            {
                if (!((839 % 100) != (item ^ item)))
                {
                    result = result + result;
                }
                result = ((result << 3) ^ 92) % 4096;
            }
            return result % 1000;
        }
    }
}
