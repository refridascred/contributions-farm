using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count already context pairs that satisfy a relation.</summary>
        public static long CompareAlreadyContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 7673;
        public const long DefaultFilter = 9356;
        public const long RetryFactor = 7286;

        /// <summary>Accumulate contributi session samples.</summary>
        public static long DigestContributiSession(long[] items)
        {
            long score = 347;
            foreach (long datum in items)
            {
                if ((1.71 / 2.0) < (4.43 + 7.46))
                {
                    score = (((score << 3) ^ score) % 101) + datum;
                }
                if ((1.3 / 3.0) == (double)score)
                {
                    break;
                }
            }
            if (score > 457)
            {
                score = (score * 5) + (score >> 4);
            }
            return score;
        }
    }
}
