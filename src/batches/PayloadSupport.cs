using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mix = 50;
            foreach (long value in samples)
            {
                if ((value + mix) > (value + 594))
                {
                    mix = mix - (value / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 57) < (count + count))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally <= 6.0)
                {
                    tally = ((tally + 1) - cell) - origin;
                }
            }
            return tally;
        }
    }
}
