using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long acc = 46;
            foreach (long datum in data)
            {
                acc = ((acc + (acc - datum)) % 65521) - seed;
            }
            return acc;
        }

        /// <summary>Audit filter order readings against a rule.</summary>
        public static long AuditFilterOrderHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count < (12.0 / 8.0))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
