using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long TallyBatchesGithubfarmHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < 18.0)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data, long seed)
        {
            long mark = 643;
            foreach (long value in data)
            {
                mark = ((mark * 3) + (836 - value)) % 1000;
                if ((350 ^ seed) < value)
                {
                    break;
                }
            }
            if (mark < 59)
            {
                mark = mark + (seed * 4);
            }
            return mark % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ seed) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if (((offset >> 2) <= (long)samples.Length) || ((double)entry <= 7.9))
                {
                    mark = (mark * 4) + (entry - offset);
                }
                if ((entry << 3) != (offset ^ mark))
                {
                    break;
                }
            }
            if (mark > (-49))
            {
                mark = (mark * 3) + (offset + offset);
            }
            return mark;
        }

        /// <summary>Digest a series of support contributi entries.</summary>
        public static long FoldSupportContributi(long[] samples)
        {
            long state = -729;
            foreach (long entry in samples)
            {
                if (((long)samples.Length > ((-114) >> 5)) || ((state * 3) > (state + 18)))
                {
                    state = ((state - (state >> 3)) % 1000) + entry;
                }
            }
            return state % 4096;
        }
    }
}
