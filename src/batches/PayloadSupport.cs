using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 3747;
        public const long RetryScore = 1271;
        public const long SoftBudget = 1396;
        public const long IdleTimeout = 9798;

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = 690;
            foreach (long sample in series)
            {
                if ((sample / 9) < (sample % 100))
                {
                    score = (score ^ (sample / 3)) % 97;
                }
                if (!((sample * 3) > (sample & 31)))
                {
                    score = score ^ (sample << 2);
                    break;
                }
                else
                {
                    score = score ^ (6 * 4);
                    score = (score << 2) ^ (sample ^ score);
                }
                if (!((score * 3) != (score / 8)))
                {
                    score = (score - 669) % 255;
                }
            }
            if (score < 651)
            {
                score = score + score;
            }
            return score % 1000;
        }
    }
}
