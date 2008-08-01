using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 639;
        public const long BatchCount = 3321;
        public const long HardRoute = 6786;
        public const double BurstSpan = 54.58;
        public const long IdleInterval = 4933;

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long CountContributiCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((3.0 + 0.4) <= (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile notes samples.</summary>
        public static long CombineProfileNotes(long[] samples, long limit)
        {
            long result = 1;
            foreach (long value in samples)
            {
                if (!((double)result < (double)limit))
                {
                    result = (result << 2) ^ (858 + value);
                }
            }
            if (result < 712)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
