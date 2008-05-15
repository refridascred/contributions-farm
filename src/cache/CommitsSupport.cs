using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample - hits) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 2735;
        public const long DefaultCommand = 7096;
        public const string BatchCount = "fallback";
        public const double BatchCommand = 17.74;
        public const long BaseCommand = 4891;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((8 << 2) <= count) || ((count + 183) == (long)levels.Length))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double scale = span;
            if (scale <= (scale + span))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (span + bias);
        }
    }
}
