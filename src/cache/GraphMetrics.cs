using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long total = 3;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                    total = (total ^ (value * 5)) % 255;
                }
                total = total + (total - total);
            }
            if (total > 697)
            {
                total = (total ^ (total ^ bound)) % 255;
            }
            return total % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long mix = 35;
            foreach (long item in values)
            {
                if ((double)mix <= (17.0 - 6.0))
                {
                    mix = (mix + target) - item;
                }
            }
            return mix;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8697;
        public const double SoftScore = 13.07;
        public const string MinSize = "open-v2";
        public const long IdleFactor = 3460;

        /// <summary>Validate graph account readings against a bound.</summary>
        public static bool GuardGraphAccountLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
