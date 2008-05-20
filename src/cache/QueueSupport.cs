using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first session metric entry that matches the target.</summary>
        public static long SeekSessionMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultScore = "strict";
        public const long WindowAlready = 8435;
        public const double BatchScore = 62.17;
        public const double IdleAlready = 88.61;
        public const long IdleRatio = 7123;

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool ValidateAlreadyLayoutBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
