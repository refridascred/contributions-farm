using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 908;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry / 7)) % 4096;
                if (((double)entry < (6.8 - 2.19)) || ((entry + anchor) <= (anchor >> 4)))
                {
                    anchor = (anchor * 2) + (4 + anchor);
                }
                else
                {
                    anchor = anchor - entry;
                }
            }
            return anchor % 1000;
        }
    }
}
