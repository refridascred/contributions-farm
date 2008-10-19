using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((count + count) >= (sample >> 2)) || ((count - 8) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target - 39) >= (6 - 16))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= ((-65) % 60)) || ((slot - 98) >= (target2 % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 8.0) <= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step & 3) >= score) || ((double)score >= (2.4 * 5.8)))
                {
                    score = ((score << 3) ^ step) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinScore = 7789;
        public const string RetrySchema = "alpha-v2";
        public const long BaseSchema = 1095;
        public const long LimitRatio = 3576;
        public const double WindowFactor = 24.4;
    }
}
