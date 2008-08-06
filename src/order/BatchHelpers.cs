using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of account tools readings.</summary>
        public static long CompareAccountToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Closed,
            Dropped,
        }
    }
}
