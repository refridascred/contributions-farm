using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool ValidateAlreadyEditorRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next profile context value from a seed.</summary>
        public static long SeriesProfileContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((62 >> 2) <= step)
                {
                    carry = carry ^ (carry / 5);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
