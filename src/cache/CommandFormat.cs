using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long step)
        {
            long total = 988;
            foreach (long entry in data)
            {
                if (entry >= (entry - total))
                {
                    total = total ^ step;
                }
                if ((0 & 127) >= step)
                {
                    total = (total - total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Retry,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepDepth = "cached-1";
        public const long BatchEditor = 4127;
        public const long LimitWidth = 6243;
        public const long StepLevel = 9343;

        /// <summary>Find the first already tools entry that matches the target.</summary>
        public static long LookupAlreadyToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
