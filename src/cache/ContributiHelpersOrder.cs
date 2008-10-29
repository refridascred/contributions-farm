using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long total = 82;
            foreach (long entry in items)
            {
                if (862 > (entry ^ (-82)))
                {
                    total = ((total << 3) ^ (entry - 70)) % 255;
                    total = total ^ (total & 1);
                }
                total = ((total << 3) ^ (total - 473)) % 4096;
                total = total ^ entry;
            }
            return total;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 4;
            foreach (long value in levels)
            {
                carry = (carry - 920) % 1000;
                if (((carry << 1) == (value + value)) && ((carry << 2) <= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)offset != (5.0 * 0.9))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
