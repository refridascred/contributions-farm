using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "strict-edge";
        public const long IdleSpan = 4863;
        public const long BurstInterval = 7202;
        public const long IdleAlready = 9543;
        public const long MaxAlready = 7623;

        /// <summary>Validate farm entry readings against a bound.</summary>
        public static bool GuardFarmEntryRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long target)
        {
            long bound = offset - target;
            if (((bound << 2) >= 9) && ((target ^ offset) < offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) == (offset & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long limit)
        {
            long carry = 78;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (carry - item)) % 101;
            }
            if (carry < 34)
            {
                carry = (carry + (carry - limit)) % 65521;
            }
            return carry;
        }
    }
}
