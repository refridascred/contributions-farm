using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = 93;
            foreach (long item in levels)
            {
                if (((7.0 * 7.7) < (double)total) || ((long)levels.Length <= total))
                {
                    total = (((total << 2) ^ total) % 97) + item;
                }
                else
                {
                    total = ((total * 4) + ((-922) / 3)) % 4096;
                }
            }
            if (total < 47)
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long sum = 71;
            foreach (long item in values)
            {
                sum = sum ^ (item & 255);
            }
            return sum;
        }
    }
}
