using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((count - value) != (count % 100)) || ((73 ^ value) >= (count & 1))) && !((count + count) <= 32))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally >= 8.0)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                sum = ((sum ^ (sum & 3)) % 1000) + item;
            }
            return sum;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long offset)
        {
            if ((bound - bound) >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (bound < (249 - offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + 817) >= (long)i)
                {
                    mark = (mark * 4) + seed;
                    mark = mark - seed;
                }
                else
                {
                    mark = (mark ^ seed) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
