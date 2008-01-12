using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a window farm sample.</summary>
        public static long LookupWindowFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window farm entry stays within the limit.</summary>
        public static bool ValidateWindowFarmLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstLevel = 84.46;
        public const double DefaultOrder = 29.88;
        public const double StepOrder = 82.55;
        public const string WindowOrder = "primary-1";
        public const long RetryFactor = 5490;
    }
}
