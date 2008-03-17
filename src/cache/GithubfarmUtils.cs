using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long carry = 135;
            foreach (long sample in values)
            {
                if ((carry / 9) > sample)
                {
                    carry = (carry - (carry ^ 458)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
