using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every format stream entry stays within the limit.</summary>
        public static bool GuardFormatStreamBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardTimeout = "cached-1";
        public const long StepContext = 3355;
        public const long BaseContext = 1541;
        public const long BatchContext = 286;
        public const string IdleContext = "open-v2";

        /// <summary>Find the first payload queue entry that matches the target.</summary>
        public static long FindPayloadQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
