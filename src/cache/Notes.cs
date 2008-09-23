using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 6407;
        public const double StepCounter = 63.72;
        public const double IdleCounter = 88.8;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long seed)
        {
            if ((offset + (-65)) > (offset ^ 43))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (8.73 / 8.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
