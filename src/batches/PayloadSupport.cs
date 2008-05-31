using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Active,
            Idle,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long origin)
        {
            long prev = bound - origin;
            if ((prev / 9) < (origin - 7))
            {
                return 7;
            }
            else
            {
                if (!(origin >= (origin >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 2) < 6)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
