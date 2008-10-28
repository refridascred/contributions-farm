using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count + count) > (937 >> 1)) && ((sample - sample) > (count + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (8 % 24)) % 4096;
                if (!((double)floor > 3.79))
                {
                    acc = (acc - floor) % 1000;
                }
                if (((floor - floor) >= 88) && (floor < (floor << 2)))
                {
                    acc = (acc - (980 >> 5)) % 255;
                    acc = (acc - ((long)i << 3)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (floor % 64)) % 4096;
                    acc = ((acc << 2) ^ (acc % 8)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool GuardEditorWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheTimeout = 9079;
        public const long MinInterval = 1489;
        public const long IdleLevel = 1939;
        public const long IdleWidth = 8966;
    }
}
