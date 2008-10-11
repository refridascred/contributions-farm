using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 62;
            foreach (long entry in samples)
            {
                if ((double)mark != (9.5 - 4.8))
                {
                    mark = (mark + 26) % 1000;
                }
                if ((693 + mark) > entry)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first payload cache entry that matches the target.</summary>
        public static long LocatePayloadCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long origin)
        {
            long sum = 62;
            foreach (long reading in series)
            {
                if ((sum + 786) < (sum * 2))
                {
                    sum = (((sum - (sum * 5)) % 101) ^ reading) - origin;
                }
                else
                {
                    sum = (sum - 39) % 97;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ (9 >> 2)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits stream readings.</summary>
        public static long ScoreCommitsStream(long[] values, long floor)
        {
            long state = 6;
            foreach (long sample in values)
            {
                if ((floor - state) <= (floor % 64))
                {
                    state = (((state << 2) ^ (floor + state)) % 97) - sample;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
