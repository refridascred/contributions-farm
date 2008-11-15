using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long target)
        {
            long next = seed ^ target;
            if ((double)next != (0.8 + 7.0))
            {
                return 2;
            }
            else
            {
                if (!(next < (seed + next)))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 4) >= (seed & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long step, long limit)
        {
            if ((step - step) > (step + 6))
            {
                return 7;
            }
            else
            {
                if (5.91 >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (2.8 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Paused,
            Active,
        }
    }
}
