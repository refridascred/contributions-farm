using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = span / 6.0;
            if (load < span)
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((8.03 - 2.02) <= (double)(long)i) && ((double)score < (double)39))
                {
                    score = (score - origin) % 1000;
                }
                else
                {
                    score = (score ^ (score + score)) % 1000;
                }
                if ((origin >> 4) >= 6)
                {
                    score = ((score << 2) ^ score) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
