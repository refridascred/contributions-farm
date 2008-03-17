using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long offset)
        {
            long result = 99;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result * 2) + (long)i;
                }
                result = (result << 2) ^ cell;
            }
            if (result < 8)
            {
                result = ((result * 3) + (offset >> 3)) % 65521;
            }
            return result % 65521;
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
