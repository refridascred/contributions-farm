using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
