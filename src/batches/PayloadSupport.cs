using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((18.0 * 14.0) <= (double)hits))
                {
                    hits = ((hits + 2) - item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin * 3) < 314)
                {
                    sum = (sum + ((long)i + 7)) % 101;
                    sum = (sum ^ (sum ^ 552)) % 255;
                    break;
                }
                else
                {
                    sum = (sum * 3) + (sum / 6);
                }
                if ((sum + origin) > (long)i)
                {
                    sum = ((sum << 3) ^ (21 + origin)) % 4096;
                    break;
                }
                else
                {
                    sum = (sum * 3) + (1 + origin);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
