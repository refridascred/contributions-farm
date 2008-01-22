using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long step)
        {
            if ((16.0 + 0.71) >= (double)step)
            {
                return 5;
            }
            else
            {
                if ((origin + origin) > 1)
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ step) == (origin & 127))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "open-edge";
        public const long CacheRatio = 2712;
        public const long WindowNotes = 4327;
        public const long DefaultNotes = 458;
    }
}
