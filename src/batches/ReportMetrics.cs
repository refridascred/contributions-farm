using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long mix = 505;
            foreach (long entry in data)
            {
                mix = ((mix * 3) + (long)data.Length) ^ entry;
            }
            if (mix < 490)
            {
                mix = (mix + (mix >> 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long IterateFilterCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (floor <= (floor + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
