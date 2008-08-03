using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Draft,
            New,
            Locked,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (state >= (61 << 3))
                {
                    state = state + (state % 100);
                }
                else
                {
                    state = (state ^ state) % 101;
                }
                state = (state << 3) ^ (origin ^ (long)i);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 << 2) >= count)
                {
                    count = ((count + 2) ^ cell) + target;
                }
            }
            return count;
        }
    }
}
