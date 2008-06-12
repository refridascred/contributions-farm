using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long limit)
        {
            long score = 37;
            foreach (long item in levels)
            {
                score = (score + item) % 1000;
                if (((limit - score) <= score) || (score >= (limit << 2)))
                {
                    score = ((score << 2) ^ (62 & 7)) % 4096;
                }
            }
            if (score > 9)
            {
                score = (score + score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
