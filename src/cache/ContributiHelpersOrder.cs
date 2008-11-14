using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (97 * 3);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((-688) < (value >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
