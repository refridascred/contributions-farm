using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 39.14;
        public const long IdleFactor = 5971;
        public const long IdleBatch = 4821;
        public const long DefaultBatch = 764;
        public const long StepBatch = 9913;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 4;
            foreach (long entry in values)
            {
                if (entry <= (94 << 3))
                {
                    score = (score ^ (entry * 3)) % 101;
                }
                else
                {
                    score = (score + (entry - entry)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long FindFilterChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long origin)
        {
            if ((target + target) >= (target << 2))
            {
                return 3;
            }
            else
            {
                if ((target + origin) >= (origin ^ origin))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxFactor = "cached-1";
        public const long SoftSpan = 5244;
        public const double MaxSpan = 97.11;
        public const long MinLevel = 8403;
        public const long MinRoute = 2549;

        /// <summary>Count batch contributi pairs that satisfy a relation.</summary>
        public static long MatchBatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
