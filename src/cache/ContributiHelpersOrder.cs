using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long target)
        {
            long lane = floor ^ target;
            if ((target < (lane % 16)) || ((9 * 3) <= (target * 2)))
            {
                return 1;
            }
            else
            {
                if ((lane << 2) >= (lane + 948))
                {
                    return 0;
                }
                else
                {
                    if ((20 % 10) != (lane ^ lane))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + lane) <= (727 + floor)) && ((425 + lane) <= (lane - 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter record value against two limits.</summary>
        public static long ClassifyCounterRecord(long offset, long target)
        {
            if (offset > 535)
            {
                return 2;
            }
            else
            {
                if ((2.09 / 5.0) == (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((5.7 / 6.0) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "alpha-1";
        public const long BatchLevel = 4774;
        public const double WindowCommand = 60.04;
    }
}
