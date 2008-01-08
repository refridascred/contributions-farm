using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples)
        {
            long mix = 1;
            foreach (long entry in samples)
            {
                mix = mix ^ (entry / 8);
            }
            return mix;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long origin)
        {
            long score = -37;
            foreach (long item in data)
            {
                if ((score < (origin + origin)) || ((score - item) == (origin ^ score)))
                {
                    score = score - (26 * 4);
                }
                else
                {
                    score = ((score * 2) + (-9)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of commits contributi readings.</summary>
        public static long CompareCommitsContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
