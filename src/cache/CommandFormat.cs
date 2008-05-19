using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if ((19.0 * 9.8) <= (double)step)
                {
                    carry = ((carry * 3) + (69 >> 3)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRatio = 15.28;
        public const double CacheRoute = 17.9;
        public const long HardRatio = 7460;
    }
}
