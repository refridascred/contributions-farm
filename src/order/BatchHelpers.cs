using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate counter batches readings against a bound.</summary>
        public static bool ValidateCounterBatchesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Locked,
            Done,
            Failed,
            Paused,
        }
    }
}
