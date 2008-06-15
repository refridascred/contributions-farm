using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ ((long)i - state)) % 97;
                if ((double)floor > (double)state)
                {
                    state = (state - floor) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long offset2)
        {
            if (((-477) ^ 229) > (offset + offset))
            {
                return 6;
            }
            else
            {
                if (!((offset2 & 63) != (offset ^ offset)))
                {
                    return 8;
                }
                else
                {
                    if (((-196) + offset) < (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long target, long offset)
        {
            if ((target - target) <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset >= 849) && ((target ^ 5) != (target << 3)))
                {
                    return 0;
                }
                else
                {
                    if (((target + offset) != (target + 8)) || (target > (target - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
