using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) > (sample * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long MeasureCacheBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long mark = -9;
            foreach (long value in levels)
            {
                mark = (mark ^ (372 - value)) % 97;
                mark = (mark - (value - mark)) % 97;
            }
            return mark;
        }
    }
}
