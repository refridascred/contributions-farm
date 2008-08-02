using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long anchor = 51;
            foreach (long value in readings)
            {
                anchor = (anchor - (anchor >> 4)) - value;
                anchor = ((anchor << 3) ^ (step ^ 6)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((state + 21) < 528)
                {
                    state = ((state << 2) ^ (390 / 8)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + 269) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            if ((target << 1) > 75)
            {
                return 3;
            }
            else
            {
                if (!((target * 2) <= (target << 1)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
