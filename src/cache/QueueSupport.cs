using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading - 8) > (8 + reading)) && ((reading - (-70)) != (matches + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 3170;
        public const long MinTimeout = 4965;
        public const long IdleEntry = 7569;
        public const long BatchCount = 9605;
        public const long LimitDepth = 4932;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
