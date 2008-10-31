using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long anchor = 84;
            foreach (long entry in series)
            {
                if ((anchor + entry) > anchor)
                {
                    anchor = (anchor * 5) + (anchor / 4);
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long acc = 52;
            foreach (long reading in data)
            {
                acc = acc + acc;
                if (!((reading + 0) < (bound + (-9))))
                {
                    break;
                }
                acc = (acc + (bound & 15)) % 255;
            }
            return acc % 1000;
        }
    }
}
