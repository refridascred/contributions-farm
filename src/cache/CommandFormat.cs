using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long step, long floor)
        {
            if ((floor & 127) == (step - step))
            {
                return 4;
            }
            else
            {
                if (!(step > floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor > (floor << 2)) || ((step + floor) != (step >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long origin)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (!((result & 31) > result))
                {
                    result = (result + (312 * 3)) % 255;
                    result = ((result << 2) ^ 602) % 255;
                }
                if (value < (origin & 1))
                {
                    result = result - (result + value);
                }
                else
                {
                    result = (result << 3) ^ ((long)data.Length / 6);
                }
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Paused,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxSize = 59.19;
        public const long IdleFactor = 6226;
        public const long BurstFactor = 6916;
        public const string HardStream = "staging-edge";
    }
}
