using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 917;
        public const double MaxLevel = 45.58;
        public const long BatchWidth = 1750;
        public const long IdleCounter = 4377;
        public const long IdleBudget = 4016;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)score == (0.42 * 0.43))
                {
                    score = (score << 3) ^ ((long)i ^ target);
                }
                else
                {
                    score = score - (target / 2);
                    score = (score + (score + target)) % 255;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long bound)
        {
            if (((2.1 / 9.0) < (double)origin) && ((0.9 * 9.8) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((1.8 / 5.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
