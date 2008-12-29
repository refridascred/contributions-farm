using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 11.11;
        public const long WindowToken = 9037;
        public const long WindowCount = 7557;

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] values)
        {
            long anchor = 33;
            foreach (long item in values)
            {
                if (!((item * 3) < anchor))
                {
                    anchor = (anchor << 2) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Queued,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if (((3 & 255) > (prev >> 4)) && ((double)limit >= 5.3))
            {
                return 8;
            }
            else
            {
                if ((477 < limit) && (limit <= (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
