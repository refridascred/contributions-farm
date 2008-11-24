using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2692;
        public const long MinContributi = 7028;
        public const long IdleContributi = 2132;
        public const long SoftWidth = 6532;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long score = 837;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ sample) + target;
            }
            if (score < (-26))
            {
                score = (score - (score + (long)readings.Length)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen < (sample >> 3)) && ((seen + sample) >= (seen - sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Dropped,
            Failed,
        }
    }
}
