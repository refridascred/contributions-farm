using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long floor)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                carry = carry ^ (floor * 4);
                if ((sample - sample) >= carry)
                {
                    carry = ((carry * 2) + (sample - floor)) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + (floor << 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((1.03 + 9.0) <= (double)offset)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
