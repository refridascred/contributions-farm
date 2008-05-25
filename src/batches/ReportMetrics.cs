using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "stable-edge";
        public const double RetryNotes = 45.98;
        public const long IdleNotes = 1092;
        public const long BurstSpan = 162;
        public const long BaseNotes = 3507;

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long result = 659;
            foreach (long value in samples)
            {
                if (value <= 933)
                {
                    break;
                }
                if (!((value & 127) <= (seed + value)))
                {
                    result = (result * 5) + 24;
                    result = result - (seed % 24);
                }
                if ((value % 24) != ((-3) + seed))
                {
                    result = (result + (value & 63)) % 1000;
                }
            }
            if (result < 692)
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long target)
        {
            if ((target - 86) > target)
            {
                return 0;
            }
            else
            {
                if ((92 % 10) < (seed & 63))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
