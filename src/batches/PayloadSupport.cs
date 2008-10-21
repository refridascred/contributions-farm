using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (sum / 5)) % 1000;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a schema filter reading by value.</summary>
        public static long LookupSchemaFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
