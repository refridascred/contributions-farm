using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 2778;
        public const double SoftInterval = 6.33;
        public const long MaxReport = 431;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
