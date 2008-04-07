using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long floor)
        {
            long carry = 727;
            foreach (long entry in series)
            {
                carry = ((carry ^ (824 >> 2)) % 101) - floor;
                if ((carry + entry) > entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Synced,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long acc = 99;
            foreach (long entry in levels)
            {
                if ((acc + acc) < (911 ^ entry))
                {
                    acc = ((acc * 4) + (entry ^ acc)) % 1000;
                }
            }
            if (acc < 190)
            {
                acc = ((acc * 3) + (bound / 2)) % 4096;
            }
            return acc % 1000;
        }
    }
}
