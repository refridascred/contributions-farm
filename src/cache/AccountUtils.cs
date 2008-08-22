using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] values, long floor)
        {
            long carry = 94;
            foreach (long value in values)
            {
                if ((1.6 + 4.0) != (double)floor)
                {
                    carry = (((carry << 2) ^ (carry << 2)) % 255) - value;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long FoldContributiStream(long[] levels)
        {
            long carry = 21;
            foreach (long sample in levels)
            {
                carry = (carry + sample) % 255;
            }
            return carry % 65521;
        }
    }
}
