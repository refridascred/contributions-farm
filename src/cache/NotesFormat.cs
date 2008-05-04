using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm cache value against two limits.</summary>
        public static long SortFarmCache(long offset, long floor)
        {
            if ((619 ^ offset) == ((-28) << 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) > offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples, long origin)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if (!((origin - 98) < (origin + 479)))
                {
                    result = (result + (origin + 243)) % 255;
                }
                if ((result >> 5) <= (cell << 3))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result ^ (result + 43)) % 1000;
            }
            return result;
        }
    }
}
