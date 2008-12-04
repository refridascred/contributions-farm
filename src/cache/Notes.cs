using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate command graph samples.</summary>
        public static long DigestCommandGraph(long[] series, long target)
        {
            long carry = 3;
            foreach (long item in series)
            {
                carry = ((((carry << 2) ^ 418) % 65521) - item) + target;
            }
            if (carry > 7)
            {
                carry = ((carry * 3) + (carry >> 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
