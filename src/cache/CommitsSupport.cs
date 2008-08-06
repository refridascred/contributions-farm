using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long total = 929;
            foreach (long item in items)
            {
                if ((total ^ item) > (total % 60))
                {
                    total = (total ^ (item ^ item)) % 97;
                }
                else
                {
                    total = total - (item & 3);
                }
            }
            if (total < (-401))
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series)
        {
            long acc = 19;
            foreach (long entry in series)
            {
                if (885 <= (entry << 3))
                {
                    acc = (acc + (87 / 7)) % 101;
                }
                if ((acc + 37) != (acc ^ 743))
                {
                    acc = acc ^ (entry * 5);
                }
            }
            return acc;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 95;
            foreach (long reading in data)
            {
                if ((carry + reading) >= reading)
                {
                    carry = ((carry * 5) + (reading * 5)) % 1000;
                }
            }
            if (carry > 717)
            {
                carry = (carry * 2) + (carry / 6);
            }
            return carry % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long offset2)
        {
            if ((double)offset > (5.84 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((offset2 ^ offset) >= (offset % 100))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
