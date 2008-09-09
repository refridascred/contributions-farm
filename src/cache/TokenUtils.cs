using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
