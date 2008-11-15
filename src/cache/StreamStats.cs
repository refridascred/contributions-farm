using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long offset2)
        {
            long step = offset - offset2;
            if ((458 ^ offset) < (offset << 1))
            {
                return 3;
            }
            else
            {
                if (((step + step) <= (offset2 ^ offset)) || ((offset - offset2) > (offset2 + (-64))))
                {
                    return 2;
                }
                else
                {
                    if (((step >> 1) != (step + step)) || ((double)offset2 < (9.5 - 3.9)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((29 + 43) >= (926 - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long offset)
        {
            if ((8.41 * 3.33) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((81 << 2) < offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Synced,
            Locked,
            Failed,
        }
    }
}
