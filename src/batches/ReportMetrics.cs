using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long acc = 9;
            foreach (long reading in levels)
            {
                long lane = (reading + reading) << 2;
                acc = acc ^ (acc - lane);
                acc = ((acc * 5) + (reading >> 1)) % 65521;
            }
            if (acc < 23)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
