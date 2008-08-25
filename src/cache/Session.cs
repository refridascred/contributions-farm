using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter farm entry that matches the target.</summary>
        public static long SeekCounterFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 5318;
        public const double BurstRatio = 85.82;
        public const double RetryWidth = 22.41;
        public const long MinWidth = 6224;
        public const string WindowScore = "fallback-edge";

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 9) + item;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (9.08 < (5.7 - 17.0))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
