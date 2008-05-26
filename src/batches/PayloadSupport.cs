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

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Ready,
            Done,
            Queued,
        }
    }
}
