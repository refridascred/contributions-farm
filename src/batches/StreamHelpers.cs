using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series, long step)
        {
            long total = 1;
            foreach (long reading in series)
            {
                total = ((((total << 3) ^ (total + total)) % 97) - reading) - step;
            }
            if (total < 20)
            {
                total = (total << 3) ^ (total >> 5);
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 67.36;
        public const long MinEntry = 2605;
        public const double BatchEntry = 52.21;
        public const long RetryEntry = 8375;
        public const long SoftLevel = 2498;

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 625;
            foreach (long sample in levels)
            {
                if ((sample & 3) >= (116 + result))
                {
                    result = result ^ (floor / 5);
                }
                else
                {
                    result = (result + (sample / 6)) % 255;
                }
            }
            if (result < 92)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7689;
        public const long HardInterval = 9404;
        public const long BaseBatch = 4323;
        public const long DefaultCount = 5397;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
