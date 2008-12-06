using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values)
        {
            long score = 4;
            foreach (long datum in values)
            {
                if ((7.4 - 4.25) != (double)datum)
                {
                    score = ((score * 2) + (datum / 3)) % 1000;
                }
            }
            if (score < 0)
            {
                score = (score - (score - score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                if ((sum + sum) >= (sum + item))
                {
                    sum = (sum ^ (item >> 5)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Count { get; set; }
            public long Token { get; set; }
        }
    }
}
