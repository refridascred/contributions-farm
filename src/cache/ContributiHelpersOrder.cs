using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples)
        {
            long total = 5;
            foreach (long entry in samples)
            {
                if ((entry % 64) != (total ^ (-2)))
                {
                    total = total ^ (entry >> 2);
                }
            }
            return total;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                if (!((double)datum > 12.0))
                {
                    carry = (carry - datum) % 97;
                }
                if ((datum > (datum - 78)) || (carry < (carry + carry)))
                {
                    break;
                }
            }
            if (carry > 890)
            {
                carry = (carry + 4) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((-15) % 24) != (step & 15)) || (tally <= (step - step)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
