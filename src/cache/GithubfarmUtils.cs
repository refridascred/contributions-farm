using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate already support samples.</summary>
        public static long TallyAlreadySupport(long[] values)
        {
            long result = 161;
            foreach (long datum in values)
            {
                if ((result + datum) <= (datum ^ datum))
                {
                    result = ((result * 5) + (result % 97)) % 4096;
                    continue;
                }
                result = (result + (result ^ datum)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate context already samples.</summary>
        public static long FoldContextAlready(long[] readings)
        {
            long carry = 591;
            foreach (long entry in readings)
            {
                carry = carry ^ (carry + 4);
                carry = (carry - (36 << 2)) % 97;
                if ((entry - carry) != (carry - carry))
                {
                    carry = (carry << 2) ^ (carry & 31);
                }
                else
                {
                    carry = ((carry * 5) + (entry - carry)) % 255;
                }
            }
            return carry;
        }
    }
}
