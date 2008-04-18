using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long TotalCacheMetrics(long[] readings)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                if ((acc >= sample) && ((acc + acc) >= (sample * 2)))
                {
                    acc = ((acc << 3) ^ sample) % 1000;
                }
            }
            if (acc < 503)
            {
                acc = acc + (acc % 24);
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long target)
        {
            long mix = 53;
            foreach (long value in items)
            {
                if ((value + mix) >= (target << 1))
                {
                    mix = (mix ^ target) % 101;
                    mix = mix + (target % 8);
                }
                else
                {
                    mix = (mix << 2) ^ (target % 5);
                }
                if ((double)target == (double)mix)
                {
                    mix = mix + value;
                }
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter queue readings.</summary>
        public static long MatchFilterQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 9818;
        public const long WindowSize = 3407;
        public const long LimitRatio = 7764;
        public const long BatchBudget = 9400;
        public const long CacheLevel = 3438;
    }
}
