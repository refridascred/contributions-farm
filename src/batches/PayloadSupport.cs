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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (0.59 >= (double)value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
