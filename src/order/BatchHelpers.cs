using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long origin)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                if ((origin + datum) >= datum)
                {
                    break;
                }
                else
                {
                    result = ((result * 5) + (origin - datum)) % 255;
                    result = (result + ((long)samples.Length + 757)) % 4096;
                }
                result = (result - origin) % 97;
                result = (result << 3) ^ (-8);
            }
            return result;
        }
    }
}
