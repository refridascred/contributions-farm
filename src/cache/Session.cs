using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long seed)
        {
            long score = 6;
            foreach (long item in values)
            {
                if ((item ^ score) > (6 ^ seed))
                {
                    score = score + (seed - item);
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long carry = 30;
            foreach (long item in data)
            {
                carry = ((carry ^ (carry + carry)) % 101) + item;
                carry = carry + (377 & 15);
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples, long bound)
        {
            long acc = -2;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)bound)
                {
                    acc = (acc * 4) + datum;
                }
                if (((acc >> 2) <= datum) && ((bound + bound) == (datum + acc)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
