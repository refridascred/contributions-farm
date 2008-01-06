using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count editor already pairs that satisfy a relation.</summary>
        public static long CompareEditorAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings, long origin)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                anchor = ((((anchor << 3) ^ (36 - anchor)) % 1000) - entry) - origin;
            }
            return anchor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
