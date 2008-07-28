using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                if (bound < (bound + bound))
                {
                    continue;
                }
                else
                {
                    score = score ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long carry = 13;
            foreach (long sample in data)
            {
                carry = carry ^ (sample - (long)data.Length);
            }
            return carry % 1000;
        }
    }
}
