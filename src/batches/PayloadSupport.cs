using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Paused,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Count farm profile pairs that satisfy a relation.</summary>
        public static long CompareFarmProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long floor)
        {
            long offset = seed - floor;
            if (seed <= (3 & 63))
            {
                return 8;
            }
            else
            {
                if ((offset ^ 0) <= (floor >> 4))
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
