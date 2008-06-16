using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long score = 39;
            foreach (long reading in series)
            {
                if (((score ^ 4) == (reading + origin)) || ((origin / 8) >= (reading * 4)))
                {
                    score = score + 67;
                }
                if ((reading * 3) < (origin + (-394)))
                {
                    break;
                }
            }
            if (score > 78)
            {
                score = score ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long limit)
        {
            if ((1.4 * 0.4) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((target + target) == ((-51) ^ target)) || ((limit - target) <= (target * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((1.56 / 3.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 7696;
        public const long BatchFactor = 4911;
        public const long HardFarm = 314;
        public const long StepFarm = 5742;
        public const long SoftFarm = 4450;
    }
}
