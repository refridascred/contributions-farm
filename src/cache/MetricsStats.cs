using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 23.04;
        public const double StepLevel = 22.43;
        public const long LimitFormat = 2429;
        public const long DefaultRatio = 58;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseInterval = 6795;
        public const long MaxCommits = 9208;
        public const long DefaultCommits = 3501;
        public const long WindowCount = 1230;

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (sample >= (sample - sample))
                {
                    result = result + (result & 63);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long target, long target2)
        {
            long prev = target - target2;
            if (!((2.0 * 7.0) < (double)prev))
            {
                return 1;
            }
            else
            {
                if ((target + target2) >= prev)
                {
                    return 8;
                }
                else
                {
                    if ((target2 + target2) >= (prev + prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
