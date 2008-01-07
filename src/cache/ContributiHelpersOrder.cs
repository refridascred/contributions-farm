using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 14.32;
        public const long BurstInterval = 6235;
        public const long LimitFarm = 7379;
        public const long CacheFarm = 2426;

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long bound, long origin)
        {
            long edge = bound - origin;
            if (((origin + 924) <= (edge / 7)) || ((bound + origin) >= origin))
            {
                return 6;
            }
            else
            {
                if ((double)edge <= (15.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((bound / 2) > (bound << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((-2) < (origin * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
