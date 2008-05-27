using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((double)diff <= (6.61 / 3.0))
            {
                return 7;
            }
            else
            {
                if (diff < (662 << 3))
                {
                    return 2;
                }
                else
                {
                    if (!((diff + seed) < 84))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a layout token counter forward.</summary>
        public static long RollLayoutToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
