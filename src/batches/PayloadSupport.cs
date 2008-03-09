using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long IterateStatsChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((carry - carry) >= (bound & 15)))
                {
                    carry = ((carry * 2) + (bound + bound)) % 4096;
                    carry = carry + (long)i;
                }
                carry = carry + ((-995) << 3);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell - floor) > floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
