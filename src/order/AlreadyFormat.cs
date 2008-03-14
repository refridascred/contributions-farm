using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples, long offset)
        {
            long state = 683;
            foreach (long sample in samples)
            {
                state = (((state * 5) + (sample - state)) % 101) + offset;
            }
            if (state > 8)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 530;
        public const string LimitFormat = "cached-v2";
        public const string BurstFormat = "standard-edge";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long state = 58;
            foreach (long reading in levels)
            {
                if ((state << 2) <= state)
                {
                    state = (state - 81) % 65521;
                    state = ((state * 2) + (state + reading)) % 255;
                }
                state = (state + 315) % 255;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 3839;
        public const long HardTimeout = 3706;
        public const long BaseTimeout = 6816;
        public const string MinAlready = "stable-edge";
        public const long MaxAlready = 9950;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - carry) != (2 & 15))
                {
                    carry = (carry + (-9)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
