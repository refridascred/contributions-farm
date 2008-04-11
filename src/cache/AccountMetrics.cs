using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next tools queue value.</summary>
        public static double BlendToolsQueue(double gain, double bias)
        {
            double weight = gain;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + weight) - (double)(long)i) - bias;
            }
            return weight + (gain * 4.1);
        }

        /// <summary>Check that every payload profile entry stays within the limit.</summary>
        public static bool VerifyPayloadProfileLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double load = rate;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - (8.22 * 3.1);
            }
            return load + (double)6;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long step)
        {
            if ((origin + 78) <= (origin & 31))
            {
                return 8;
            }
            else
            {
                if ((7.2 + 16.0) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 19.09;
        public const string IdleToken = "cached-edge";
        public const long CacheToken = 4350;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
