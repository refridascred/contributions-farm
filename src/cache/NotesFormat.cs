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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstLevel = 84.46;
        public const double DefaultOrder = 29.88;
        public const double StepOrder = 82.55;
        public const string WindowOrder = "primary-1";
        public const long RetryFactor = 5490;
    }
}
