using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a schema command value against two limits.</summary>
        public static long ClassifySchemaCommand(long limit, long offset)
        {
            if (((7.66 / 3.0) > (double)offset) || ((limit % 12) < (limit - 97)))
            {
                return 3;
            }
            else
            {
                if ((offset + limit) < (limit / 5))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Draft,
            Active,
            Synced,
            Queued,
        }
    }
}
