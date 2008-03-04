using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long GradeMetricCommits(long origin, long step)
        {
            if ((origin / 3) <= (step & 63))
            {
                return 1;
            }
            else
            {
                if (((origin - step) == (origin & 255)) || ((double)step == (12.0 - 3.0)))
                {
                    return 6;
                }
                else
                {
                    if ((step + (-828)) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((68 - 78) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 9436;
        public const long HardLevel = 3200;
        public const long MinLevel = 215;
        public const string WindowSize = "open-edge";
    }
}
