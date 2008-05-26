using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (floor - carry)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings)
        {
            long score = -307;
            foreach (long entry in readings)
            {
                if (((score + entry) == (entry * 2)) || (entry <= (score / 3)))
                {
                    score = (score - (score + score)) % 97;
                }
            }
            if (score > 481)
            {
                score = (score << 2) ^ (score - score);
            }
            return score;
        }
    }
}
