using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
