using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long state = 395;
            foreach (long datum in items)
            {
                if ((22 - 13) >= (datum & 31))
                {
                    state = ((state << 3) ^ ((-794) + state)) % 4096;
                }
                else
                {
                    state = (state ^ 755) % 4096;
                    state = (state * 2) + (-5);
                }
                state = (state ^ (datum >> 1)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Queued,
            New,
            Pending,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "fallback-1";
        public const long IdleFilter = 3681;
        public const double BurstSize = 29.02;
        public const long StepWidth = 1264;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 7367;
        public const long SoftOrder = 3144;
        public const long IdleOrder = 3082;

        /// <summary>Measure how many metrics profile samples are out of range.</summary>
        public static long CountMetricsProfileMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((((-870) & 255) != (count + limit)) && ((limit + 6) == (count ^ sample))) && (((17.0 * 3.6) < (double)limit) || ((count - limit) <= sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
