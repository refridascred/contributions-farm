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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
