using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count buffer layout pairs that satisfy a relation.</summary>
        public static long MatchBufferLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -6;
            foreach (long entry in readings)
            {
                anchor = anchor + (entry + anchor);
                if ((1.3 * 2.0) > (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count batch metrics pairs that satisfy a relation.</summary>
        public static long MatchBatchMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
