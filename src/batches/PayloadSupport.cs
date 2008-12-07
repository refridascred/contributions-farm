using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 7) == (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (7 * 4)) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series)
        {
            long carry = 5;
            foreach (long reading in series)
            {
                carry = (carry * 3) + reading;
            }
            return carry;
        }
    }
}
