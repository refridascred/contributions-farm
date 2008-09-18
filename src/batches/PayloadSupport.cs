using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long bound)
        {
            if (95 >= (bound / 6))
            {
                return 0;
            }
            else
            {
                if ((bound << 3) < (29 / 9))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                result = result ^ (entry + entry);
            }
            if (result < 5)
            {
                result = ((result * 5) + (target - target)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + result) >= seed)
                {
                    result = result ^ (seed * 4);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
