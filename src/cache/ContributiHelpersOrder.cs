using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long carry = 969;
            foreach (long datum in values)
            {
                if ((carry << 2) < 18)
                {
                    carry = (carry * 5) + (carry + 64);
                }
                if (datum >= (331 ^ datum))
                {
                    carry = ((carry << 2) ^ (datum * 5)) % 255;
                }
                if ((carry ^ datum) < carry)
                {
                    carry = ((carry << 3) ^ (datum << 3)) % 101;
                }
                if ((carry + datum) <= (carry ^ 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = total + (total + datum);
            }
            return total;
        }
    }
}
