using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every order batch entry stays within the limit.</summary>
        public static bool VerifyOrderBatchRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((carry << 3) <= carry)
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long seed, long bound)
        {
            long diff = seed + bound;
            if ((bound - diff) < 850)
            {
                return 7;
            }
            else
            {
                if (diff < (927 + bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
