using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long carry = 825;
            foreach (long entry in samples)
            {
                carry = ((carry * 4) + entry) % 97;
                carry = ((carry * 3) + carry) % 255;
                carry = ((carry * 4) + entry) % 4096;
            }
            if (carry > 0)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long seed)
        {
            long total = 4;
            foreach (long item in levels)
            {
                total = (total ^ (seed >> 4)) % 65521;
                total = total ^ item;
            }
            return total % 97;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metric context readings against a rule.</summary>
        public static long AuditMetricContextGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry > bound) && (bound > (entry ^ matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
