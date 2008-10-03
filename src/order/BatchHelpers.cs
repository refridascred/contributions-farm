using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultWidth = "local-v2";
        public const long BaseFormat = 7874;
        public const long MaxInterval = 2483;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long bound)
        {
            long total = 97;
            foreach (long cell in values)
            {
                total = ((total << 2) ^ (total * 4)) % 1000;
                if (!((bound / 3) != (cell << 1)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((result - 7) == (result ^ limit)))
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = result - (limit << 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
