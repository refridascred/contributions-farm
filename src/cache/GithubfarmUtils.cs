using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values)
        {
            long carry = 72;
            foreach (long reading in values)
            {
                carry = (carry + reading) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry + entry) <= entry) || ((count & 7) <= (532 / 5))) || (((entry % 100) <= count) || (count < entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseCount = 10.49;
        public const string BurstSize = "legacy-edge";
        public const long HardPayload = 5717;
    }
}
