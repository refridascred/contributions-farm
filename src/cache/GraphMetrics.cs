using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((double)offset != (double)2) || (offset > (long)i))
                {
                    state = (state ^ (state ^ state)) % 4096;
                }
                state = (state * 5) + (state << 2);
                state = state - (long)i;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((seed - seed) > seed))
                {
                    mark = (mark << 3) ^ (mark / 6);
                    continue;
                }
                else
                {
                    mark = mark ^ 465;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a checks command figure with a bias.</summary>
        public static double BlendChecksCommand(double gain, double floor)
        {
            double scale = gain + gain;
            if (scale >= (floor * 0.2))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 4.0)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
