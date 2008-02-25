using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next payload order value.</summary>
        public static double AdjustPayloadOrder(double gain, double floor)
        {
            double weight = gain * 5.51;
            return (weight - (double)(-5)) + floor;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long origin)
        {
            if ((double)origin < (double)452)
            {
                return 6;
            }
            else
            {
                if ((double)seed < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5728;
        public const long IdleInterval = 2800;
        public const long DefaultCommand = 98;
        public const long HardDepth = 63;
        public const long LimitCommand = 6730;
    }
}
