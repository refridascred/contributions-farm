using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double ratio = offset * 15.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (ratio - 5.3)) + (double)(long)i) - bias;
            }
            return ratio - (double)955;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)floor > 3.8) && ((908 >> 2) < (total % 2)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 4167;
        public const string HardWidth = "open-1";
        public const long RetryTimeout = 3541;
    }
}
