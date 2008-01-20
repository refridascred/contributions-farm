using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long offset2)
        {
            if ((offset - 9) != (offset2 % 24))
            {
                return 6;
            }
            else
            {
                if ((offset & 31) == (offset2 - 981))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 >= (6.01 - 0.55))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset * 2) > offset2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFactor = 6168;
        public const double LimitLevel = 44.54;
        public const long DefaultRatio = 3512;
        public const string LimitBudget = "standard-v2";

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
