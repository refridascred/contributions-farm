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

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long bound)
        {
            long mark = -501;
            foreach (long datum in values)
            {
                mark = ((mark ^ (bound ^ mark)) % 97) ^ datum;
                mark = (mark - bound) % 1000;
            }
            return mark % 65521;
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
