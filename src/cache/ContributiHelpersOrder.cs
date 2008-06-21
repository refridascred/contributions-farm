using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWidth = "strict-edge";
        public const long IdleWindow = 654;
        public const long LimitWidth = 2929;
        public const double LimitRatio = 88.9;
        public const long MaxWindow = 4199;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long step, long seed)
        {
            long delta = step ^ seed;
            if ((seed + delta) != (1 << 1))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (seed < (step + 766))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed != (7.0 - 0.71))
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

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
