using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long floor)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ (sample - sample)) % 101) - floor;
            }
            if (sum > 191)
            {
                sum = sum + ((long)readings.Length / 4);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((28 % 10) != (seen >> 5))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 66.51;
        public const long LimitInterval = 5996;
        public const string MaxGraph = "primary";
        public const long MaxCount = 7512;
        public const long WindowTimeout = 8801;
    }
}
