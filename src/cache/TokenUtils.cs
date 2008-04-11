using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Retry,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 5) >= (step + step))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
