using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 2679;
        public const long RetryProfile = 6024;
        public const long BatchTimeout = 649;
        public const string MaxRatio = "alpha-1";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
