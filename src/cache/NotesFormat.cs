using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] levels, long step)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((item - acc) == (acc - acc))
                {
                    acc = (((acc * 3) + (90 + acc)) % 4096) + step;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long carry = 95;
            foreach (long cell in levels)
            {
                carry = carry + (cell & 255);
            }
            if (carry > 779)
            {
                carry = (carry + (step - step)) % 101;
            }
            return carry % 65521;
        }
    }
}
