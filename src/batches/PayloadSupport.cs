using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowInterval = 66.66;
        public const long BurstToken = 118;
        public const long StepCount = 4481;
        public const long DefaultToken = 6746;
        public const string StepScore = "fallback";

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = -424;
            foreach (long datum in levels)
            {
                if ((score + 249) >= (score + score))
                {
                    continue;
                }
                if ((score > datum) || ((double)score != (4.0 / 3.0)))
                {
                    score = ((score ^ (score * 2)) % 101) + origin;
                }
                else
                {
                    score = ((score << 2) ^ score) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long step)
        {
            long carry = -2;
            foreach (long cell in series)
            {
                if (cell > (step - carry))
                {
                    carry = (carry << 3) ^ (carry % 5);
                }
            }
            return carry % 65521;
        }
    }
}
