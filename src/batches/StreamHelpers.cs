using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading + count) > (reading & 63)) || ((count << 1) >= (reading % 100)))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long ScoreCacheBatch(long[] series)
        {
            long mix = 245;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long TallyCommandCacheMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - seen) == (715 % 12))
                {
                    seen = ((seen + 3) + item) + seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream buffer reading by value.</summary>
        public static long LookupStreamBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if (((27 ^ acc) < (item - item)) && ((item - item) != (acc >> 1)))
                {
                    acc = (acc + acc) % 4096;
                }
                if ((acc + 558) > acc)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Active,
            Idle,
            Ready,
            Closed,
        }
    }
}
