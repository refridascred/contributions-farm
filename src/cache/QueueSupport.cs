using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command stats value against two limits.</summary>
        public static long ClassifyCommandStats(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((bound + bound2) > (bound - bound2))
            {
                return 3;
            }
            else
            {
                if ((8.03 * 1.0) != (double)bound3)
                {
                    return 2;
                }
                else
                {
                    if ((149 - bound) == (bound3 + bound3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound >> 1) > (bound << 3)) && ((double)bound3 > (2.0 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score ^ (offset & 127)) % 65521;
                    score = (score << 2) ^ ((long)i2 & 31);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Closed,
            Failed,
        }
    }
}
