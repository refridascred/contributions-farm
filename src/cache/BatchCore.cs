using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate metric window samples.</summary>
        public static long FoldMetricWindow(long[] series, long target)
        {
            long carry = 50;
            foreach (long entry in series)
            {
                carry = (carry - (entry * 2)) % 101;
                carry = (carry - (entry * 2)) % 255;
                if ((double)carry == (double)target)
                {
                    carry = carry + (target / 9);
                }
            }
            return carry % 4096;
        }
    }
}
