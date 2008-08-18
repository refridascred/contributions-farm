using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long target)
        {
            long lane = offset + target;
            if ((lane >= (target / 9)) || ((double)lane <= (3.9 - 20.0)))
            {
                return 4;
            }
            else
            {
                if (!((-13) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((25 + acc) != (datum & 127))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc > 92)
            {
                acc = acc ^ ((long)data.Length ^ acc);
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftRatio = "legacy";
        public const long BaseCluster = 3497;
        public const long BatchDepth = 1074;
        public const double MinLevel = 60.18;
    }
}
