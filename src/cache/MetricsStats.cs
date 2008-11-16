using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result - offset) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
