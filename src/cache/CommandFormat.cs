using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values)
        {
            long carry = 717;
            foreach (long reading in values)
            {
                if (carry <= (reading / 9))
                {
                    carry = (carry + (carry ^ reading)) % 97;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (carry >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Stale,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool VerifyOrderMetricsBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
