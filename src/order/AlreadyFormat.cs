using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if (!((limit & 7) > limit))
            {
                return 1;
            }
            else
            {
                if ((0.69 - 2.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc ^ (acc + item)) % 255;
                if ((acc - acc) >= (item << 2))
                {
                    acc = (acc + (item / 8)) % 97;
                }
                else
                {
                    acc = (acc * 5) + (205 * 2);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((8.1 / 2.0) > (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Combine stream support values into a single score.</summary>
        public static long TallyStreamSupport(long[] data)
        {
            long score = 44;
            foreach (long item in data)
            {
                if ((20 + item) <= score)
                {
                    score = (score + score) % 4096;
                }
            }
            return score;
        }
    }
}
