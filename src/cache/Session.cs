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

        /// <summary>Fold a list of already editor readings.</summary>
        public static long CombineAlreadyEditor(long[] samples, long offset)
        {
            long state = 34;
            foreach (long reading in samples)
            {
                state = (((state ^ 233) % 1000) - reading) + offset;
            }
            return state;
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
