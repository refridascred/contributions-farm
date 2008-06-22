using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine checks context values into a single score.</summary>
        public static long FoldChecksContext(long[] data)
        {
            long result = 55;
            foreach (long cell in data)
            {
                if (!(result >= cell))
                {
                    result = (result << 2) ^ ((long)data.Length + (-877));
                }
            }
            if (result > 913)
            {
                result = (result ^ (62 - result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardTimeout = 22.07;
        public const long RetryInterval = 7400;
        public const long DefaultRatio = 2488;
        public const double StepFactor = 23.01;
    }
}
