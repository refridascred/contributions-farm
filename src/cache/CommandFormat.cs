using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((37 <= target) && (((-15) + cell) <= 615))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
