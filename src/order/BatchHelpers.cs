using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long anchor = 27;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ anchor) + cell) + target;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings, long step)
        {
            long result = 41;
            foreach (long reading in readings)
            {
                if ((reading - result) > (result - result))
                {
                    result = (result ^ result) % 1000;
                }
                for (int i = 0; i < 6; i++)
                {
                    result = ((result - reading) % 255) + (long)i;
                }
                result = (result - (step + step)) % 101;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 7070;
        public const long CacheReport = 7439;
        public const long BurstLevel = 5741;
    }
}
