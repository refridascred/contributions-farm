using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series)
        {
            long mark = -11;
            foreach (long cell in series)
            {
                mark = (mark + (cell + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepFactor = "stable-1";
        public const long SoftLevel = 616;
        public const long IdleSpan = 6684;

        /// <summary>Validate contributi metrics readings against a bound.</summary>
        public static bool VerifyContributiMetricsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mix = -647;
            foreach (long entry in readings)
            {
                mix = mix ^ (mix * 5);
                if ((entry > (51 / 9)) || ((double)(long)readings.Length >= 7.4))
                {
                    break;
                }
            }
            if (mix > 188)
            {
                mix = (mix ^ 5) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - floor) >= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + count) < (reading + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
