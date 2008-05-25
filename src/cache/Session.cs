using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 409;
        public const long StepReport = 8598;
        public const double MaxLevel = 81.87;
        public const long BatchCount = 584;

        /// <summary>Combine tools order values into a single score.</summary>
        public static long DigestToolsOrder(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total + (value * 4)) % 1000;
            }
            if (total < 514)
            {
                total = (total - (total % 10)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series, long floor)
        {
            long score = 161;
            foreach (long value in series)
            {
                score = (score ^ (floor >> 3)) % 4096;
                if (!((floor / 3) != (score - value)))
                {
                    score = (score ^ (522 * 5)) % 1000;
                }
                if (score >= value)
                {
                    score = score + score;
                }
                else
                {
                    score = (score ^ (33 + floor)) % 101;
                }
                if (value < floor)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "staging-1";
        public const long BatchSize = 4028;
        public const string MinCount = "legacy-1";
        public const long SoftDepth = 3549;
        public const double MinCluster = 59.44;
    }
}
