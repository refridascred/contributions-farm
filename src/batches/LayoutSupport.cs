using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long sum = 46;
            foreach (long item in readings)
            {
                if ((item * 3) < (3 + item))
                {
                    sum = ((sum * 2) + (40 + sum)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (-28);
                }
                sum = (sum * 5) + (sum / 2);
                sum = sum - offset;
            }
            if (sum > 65)
            {
                sum = sum ^ (offset * 3);
            }
            return sum;
        }

        /// <summary>Measure how many stream buffer samples are out of range.</summary>
        public static long CountStreamBufferHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((-29) <= (seen / 8))
                {
                    seen = ((seen + 3) + value) + bound;
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((3.8 <= (double)mix) && ((double)(long)i == (4.43 - 19.0)))
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }
    }
}
