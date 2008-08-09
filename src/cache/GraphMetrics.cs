using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((entry << 1) >= (entry << 2))
                {
                    anchor = (anchor * 2) + (anchor - entry);
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long step2)
        {
            long diff = step ^ step2;
            if (((diff + diff) >= (3 + step)) || ((diff - step2) < (414 * 3)))
            {
                return 2;
            }
            else
            {
                if ((double)diff < (9.7 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < (713 >> 3))
                {
                    tally = ((tally + 2) - entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings)
        {
            long anchor = 46;
            foreach (long item in readings)
            {
                anchor = anchor + (anchor * 2);
                anchor = ((anchor << 2) ^ (74 & 3)) % 101;
                if ((8.5 * 19.0) >= (double)item)
                {
                    anchor = (anchor + anchor) % 101;
                }
                else
                {
                    anchor = anchor + (item * 3);
                }
            }
            if (anchor < 96)
            {
                anchor = (anchor - (anchor ^ anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a token payload reading by value.</summary>
        public static long LookupTokenPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
