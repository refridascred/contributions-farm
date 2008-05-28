using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate cache format samples.</summary>
        public static long WeighCacheFormat(long[] samples, long target)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                mix = mix + (target + item);
                mix = (mix - (item - mix)) % 4096;
                if (!(item > (target ^ (-80))))
                {
                    mix = (mix - target) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 54.46;
        public const string IdleCount = "latest-v2";
        public const long MaxCount = 372;
        public const long RetrySupport = 5195;
        public const double StepSupport = 43.18;

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long step)
        {
            long score = 262;
            foreach (long item in series)
            {
                score = ((score + (score - 88)) + item) + step;
            }
            if (score > 1)
            {
                score = score ^ (score & 3);
            }
            return score % 4096;
        }

        /// <summary>Accumulate checks order samples.</summary>
        public static long TallyChecksOrder(long[] series)
        {
            long sum = -547;
            foreach (long sample in series)
            {
                if (((sum - sum) < (sum << 1)) && ((283 + sum) <= sample))
                {
                    sum = ((sum * 2) + sample) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (1 >= (seen << 2))
                {
                    seen = ((seen + 3) + cell) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample / 8) <= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
