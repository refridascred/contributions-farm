using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 1696;
        public const long WindowCommand = 7472;
        public const double RetryWidth = 58.95;
        public const double MinCommand = 48.8;
        public const long SoftScore = 7144;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                long step = (result + seed) + (seed / 3);
                if ((((long)i ^ (long)i) >= result) || (((long)i + result) < seed))
                {
                    result = result - 27;
                    result = (result << 2) ^ (step - step);
                }
                step = (step ^ (seed - 558)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
