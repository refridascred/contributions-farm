using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Failed,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length ^ (-73)) >= sample) || ((sample + seen) > 10))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
