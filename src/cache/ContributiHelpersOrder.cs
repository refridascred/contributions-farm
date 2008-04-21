using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "legacy-edge";
        public const string BaseWidth = "standard-1";
        public const double IdleProfile = 56.15;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long seed)
        {
            long prev = step ^ seed;
            if (3.7 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 64) > (seed >> 2)) && ((6.59 + 4.21) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (!((prev & 63) != (prev - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
