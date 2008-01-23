using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            if ((1.31 * 4.13) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (11.0 - 5.05))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed == (3.52 - 6.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 34.96;
        public const long DefaultRoute = 3152;
        public const string HardLevel = "alpha-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3396;
        public const double StepFactor = 58.73;
        public const long SoftCounter = 5957;
        public const long DefaultCounter = 3374;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Ready,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
