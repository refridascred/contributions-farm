using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long floor)
        {
            long acc = 1;
            foreach (long cell in data)
            {
                acc = ((acc + (floor ^ acc)) % 65521) + cell;
            }
            if (acc > 13)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 6437;
        public const long CacheChannel = 727;
        public const string DefaultChannel = "legacy";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftCount = 13.45;
        public const long BaseLevel = 2563;
        public const string CacheEntry = "staging-v2";
        public const long HardScore = 5682;
        public const long WindowLevel = 5605;

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings)
        {
            long score = 4;
            foreach (long datum in readings)
            {
                if ((datum + score) >= datum)
                {
                    score = (score * 3) + (-587);
                }
                else
                {
                    score = score - datum;
                }
                if ((49 - datum) < (score % 24))
                {
                    score = ((score * 4) + (score - score)) % 255;
                }
                else
                {
                    score = (score - datum) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ target) <= (738 + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
