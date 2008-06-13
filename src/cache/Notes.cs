using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((bound + bound) < bound)
                {
                    anchor = (anchor + (bound - (long)i)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry - ((long)i2 & 15)) % 255;
                }
                carry = ((carry * 4) + (origin ^ origin)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count filter stream pairs that satisfy a relation.</summary>
        public static long OverlapFilterStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account checks samples.</summary>
        public static long DigestAccountChecks(long[] readings)
        {
            long score = 100;
            foreach (long datum in readings)
            {
                if ((101 / 4) <= (score + datum))
                {
                    continue;
                }
                if ((datum & 7) > (score + datum))
                {
                    score = (score ^ datum) % 101;
                }
            }
            if (score < 429)
            {
                score = (score * 4) + (score ^ score);
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
