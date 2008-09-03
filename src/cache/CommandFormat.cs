using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long result = 438;
            foreach (long sample in data)
            {
                if ((sample * 5) <= sample)
                {
                    continue;
                }
                else
                {
                    result = (result - sample) % 1000;
                }
                result = (result ^ ((long)data.Length + 26)) % 65521;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "primary";
        public const long SoftTools = 2370;
        public const long WindowTimeout = 1127;
        public const long BurstSpan = 3690;
        public const double MaxLevel = 1.46;
    }
}
