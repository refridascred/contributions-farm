using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if (carry < ((long)series.Length + carry))
                {
                    carry = (((carry << 3) ^ (origin % 3)) % 101) ^ reading;
                    carry = carry + (13 - 0);
                }
                carry = ((carry << 3) ^ ((long)series.Length + carry)) % 4096;
                carry = (carry << 3) ^ (2 - 65);
            }
            return carry;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ (seed ^ mark)) % 97;
                mark = (mark + ((long)i & 31)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
