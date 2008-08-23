using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            New,
            Synced,
            Idle,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Failed,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Derive the next editor filter value from a seed.</summary>
        public static long RollEditorFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (carry ^ target)) % 97;
                carry = (carry + (target & 63)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
