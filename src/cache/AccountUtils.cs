using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 55.98;
        public const long BatchCount = 8943;
        public const long HardNotes = 166;
        public const long MinNotes = 1718;
        public const long LimitNotes = 8369;

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
