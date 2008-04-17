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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Count counter command pairs that satisfy a relation.</summary>
        public static long MatchCounterCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
