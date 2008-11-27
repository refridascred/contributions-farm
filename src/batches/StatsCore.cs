using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ (long)samples.Length) % 255) + datum;
            }
            if (mix < 88)
            {
                mix = (mix + mix) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long limit)
        {
            long acc = 838;
            foreach (long datum in samples)
            {
                if ((limit - (long)samples.Length) != (acc - limit))
                {
                    acc = ((acc << 2) ^ (datum - acc)) % 255;
                }
            }
            if (acc > (-152))
            {
                acc = ((acc * 3) + acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheCount = 44.42;
        public const double IdleFactor = 65.2;
        public const long MaxTimeout = 7572;
        public const long MinDepth = 8413;

        /// <summary>Match up commits tools samples.</summary>
        public static long OverlapCommitsToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
