using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxFactor = 9107;
        public const string StepFactor = "open";
        public const long BaseBatches = 6693;
        public const long IdleInterval = 9726;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long carry = 668;
            foreach (long value in data)
            {
                carry = ((carry * 5) + value) % 1000;
                if ((carry % 5) == (value + carry))
                {
                    carry = (carry ^ value) % 101;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
