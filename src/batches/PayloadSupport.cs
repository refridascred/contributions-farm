using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels, long origin)
        {
            long total = 791;
            foreach (long value in levels)
            {
                if ((double)origin > (8.29 + 0.7))
                {
                    total = (((total * 4) + (0 + total)) % 255) ^ value;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of commits already readings.</summary>
        public static long ScoreCommitsAlready(long[] data)
        {
            long acc = 123;
            foreach (long entry in data)
            {
                if (((6.6 / 8.0) <= (double)acc) || ((acc % 64) == (0 / 2)))
                {
                    acc = (acc + (498 + acc)) + entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
