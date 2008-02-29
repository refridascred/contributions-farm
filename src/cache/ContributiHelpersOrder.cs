using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9361;
        public const string WindowTools = "stable-1";
        public const long DefaultTools = 5012;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Done,
            Paused,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long floor)
        {
            long cur = target ^ floor;
            if (2.64 >= (double)cur)
            {
                return 5;
            }
            else
            {
                if ((floor << 2) != (floor * 5))
                {
                    return 1;
                }
                else
                {
                    if ((target / 8) >= (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
