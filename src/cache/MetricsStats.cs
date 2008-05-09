using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a batches profile counter forward.</summary>
        public static long DeriveBatchesProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftTimeout = 4930;
        public const long MaxScore = 4434;
        public const long LimitContributi = 2908;
        public const long DefaultContributi = 3503;
        public const long MinScore = 6403;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result << 3) ^ (target - 603)) ^ (long)i2;
                    result = result - (target / 5);
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    result = (result ^ (target - target)) - (long)i3;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
