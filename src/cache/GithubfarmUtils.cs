using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long floor)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                if (((33 + cell) >= (cell - floor)) || ((1.2 + 8.73) == (double)cell))
                {
                    carry = ((carry << 3) ^ (floor ^ carry)) % 4096;
                }
                if (!((floor - carry) < (8 & 255)))
                {
                    break;
                }
            }
            if (carry < (-4))
            {
                carry = carry + floor;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 96.08;
        public const double MinScore = 67.19;
        public const long WindowNotes = 9456;
        public const long HardSize = 7948;
        public const double StepNotes = 4.15;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
