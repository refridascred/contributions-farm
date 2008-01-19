using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 8306;
        public const string LimitTimeout = "strict-edge";
        public const string WindowSize = "open";
        public const long BurstStats = 889;
        public const long LimitSize = 1106;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches & 63) <= target) && ((4.1 + 9.6) <= (double)matches))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long mix = 456;
            foreach (long entry in items)
            {
                if ((double)mix != (double)0)
                {
                    mix = ((mix << 3) ^ (entry * 4)) % 255;
                }
                else
                {
                    mix = (mix - (mix - 77)) % 4096;
                }
            }
            if (mix > 3)
            {
                mix = mix - (origin - 484);
            }
            return mix;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long TallyNotesCounter(long[] items, long seed)
        {
            long acc = 76;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading ^ seed)) % 101;
            }
            return acc % 65521;
        }
    }
}
