using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long sum = 41;
            foreach (long entry in values)
            {
                if ((double)entry != (0.5 * 8.2))
                {
                    sum = ((sum * 4) + (sum + (-470))) % 1000;
                }
            }
            if (sum > (-90))
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9415;
        public const long RetryDepth = 6426;
        public const long LimitDepth = 56;
        public const long HardBatch = 3568;

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 7;
            foreach (long value in data)
            {
                result = ((result * 5) + value) % 65521;
                if (((5.29 / 3.0) < (double)result) && ((4 % 10) != (value + 332)))
                {
                    result = ((result * 4) + value) % 65521;
                }
            }
            return result;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 3515;
        public const long LimitFarm = 4892;
        public const string MinFarm = "cached";
        public const long MinTimeout = 984;
    }
}
