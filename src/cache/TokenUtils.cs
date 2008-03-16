using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long bound)
        {
            if ((302 + bound) >= (28 + step))
            {
                return 4;
            }
            else
            {
                if ((bound + 274) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((3.83 + 7.0) < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound << 3) <= (step / 6))
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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
