using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long CountEditorEntryOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((hits % 5) > hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry + carry);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
