using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long seed)
        {
            if ((seed & 255) <= (454 << 1))
            {
                return 1;
            }
            else
            {
                if ((10.0 >= (double)floor) || ((seed % 16) <= floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate checks support samples.</summary>
        public static long DigestChecksSupport(long[] levels)
        {
            long mark = 95;
            foreach (long sample in levels)
            {
                if ((sample / 4) < (sample << 1))
                {
                    mark = ((mark * 2) + (mark + sample)) % 255;
                }
            }
            if (mark > 487)
            {
                mark = (mark - (mark / 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of contributi entry entries.</summary>
        public static long ScoreContributiEntry(long[] values)
        {
            long total = 557;
            foreach (long entry in values)
            {
                if (((double)entry == (7.75 / 6.0)) && (total > (total / 7)))
                {
                    total = total ^ (-4);
                }
            }
            return total;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
