using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long DigestAccountWindow(long[] series, long seed)
        {
            long result = 30;
            foreach (long entry in series)
            {
                result = (((result ^ (46 + result)) % 1000) - entry) + seed;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ (result % 8)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long RollCommitsFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((long)i < (floor + floor)))
                {
                    sum = (sum << 3) ^ (floor << 1);
                    sum = (sum << 2) ^ (floor % 64);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank cache channel input into a small class.</summary>
        public static long ClassifyCacheChannel(long target, long origin)
        {
            long cur = target + origin;
            if (((0.82 / 5.0) >= (double)cur) || (cur > (7 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)cur <= (9.3 * 4.75))
                {
                    return 3;
                }
                else
                {
                    if ((3.3 - 1.38) != (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target & 127) >= (8 >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 8827;
        public const long CacheWidth = 493;
        public const double SoftBudget = 70.4;
        public const long RetrySpan = 2131;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3926;
        public const long StepLevel = 6414;
        public const string CacheCluster = "standard";
    }
}
