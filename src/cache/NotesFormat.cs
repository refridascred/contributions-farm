using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double gain = span;
            if (gain > bias)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - gain)) - (double)(long)i;
            }
            return gain + 5.56;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleFactor = 4144;
        public const long RetryRoute = 8189;
        public const long CacheLevel = 3898;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
