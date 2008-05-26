using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor cache samples.</summary>
        public static long CombineEditorCache(long[] samples)
        {
            long score = 99;
            foreach (long item in samples)
            {
                score = (score ^ item) % 65521;
            }
            return score % 97;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long target)
        {
            long anchor = 370;
            foreach (long datum in values)
            {
                if (5.0 <= (double)datum)
                {
                    anchor = anchor + (target * 3);
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
