using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value & 31) >= (value * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - hits) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + 6) < (entry - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter tools sample.</summary>
        public static long FindFilterToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = (acc << 2) ^ (entry % 24);
                if ((acc >= 66) && ((entry + 75) != (entry >> 1)))
                {
                    acc = (acc + (acc << 1)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ ((-89) / 4);
                }
            }
            if (acc < 37)
            {
                acc = acc ^ 40;
            }
            return acc;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
