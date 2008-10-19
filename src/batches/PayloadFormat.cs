using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            New,
            Idle,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if ((3.82 + 6.8) <= (double)target)
            {
                return 1;
            }
            else
            {
                if ((offset + target) >= offset)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (count & 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
