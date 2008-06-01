using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool ValidateFilterCommandBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Failed,
            Closed,
            New,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels, long limit)
        {
            long state = -13;
            foreach (long entry in levels)
            {
                if ((limit << 1) >= (entry + entry))
                {
                    state = (state << 3) ^ (limit >> 1);
                }
            }
            if (state > 99)
            {
                state = state - (limit & 31);
            }
            return state % 65521;
        }
    }
}
