using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long origin)
        {
            long total = 28;
            foreach (long datum in levels)
            {
                total = ((total << 2) ^ (total << 1)) + datum;
                for (int i = 0; i < 8; i++)
                {
                    total = ((total - ((long)levels.Length - total)) % 4096) ^ (long)i;
                }
                if (((long)levels.Length / 9) <= ((-55) << 3))
                {
                    total = (total ^ (total << 1)) % 65521;
                }
                else
                {
                    total = (total ^ total) % 1000;
                }
            }
            if (total < 44)
            {
                total = ((total << 2) ^ origin) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples, long limit)
        {
            long acc = 683;
            foreach (long reading in samples)
            {
                if (((double)reading != (5.67 / 2.0)) || (((long)samples.Length + acc) >= (limit >> 5)))
                {
                    acc = (acc * 4) + (long)samples.Length;
                }
                else
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc < (-157))
            {
                acc = (acc ^ (acc << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSize = 8488;
        public const long StepCommand = 5525;
        public const long SoftScore = 3948;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
