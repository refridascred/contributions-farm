using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up layout stream samples.</summary>
        public static long MatchLayoutStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 7351;
        public const string LimitRecord = "local-edge";
        public const string StepBudget = "local-edge";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (bound >= (seen ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
