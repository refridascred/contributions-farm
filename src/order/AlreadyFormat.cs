using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 7614;
        public const long HardGraph = 3479;
        public const string BaseBudget = "stable-edge";

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally ^ floor) <= (item - tally)) || ((item & 15) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Locked,
            Idle,
            Ready,
            New,
        }

        /// <summary>Grade a order graph value against two limits.</summary>
        public static long BucketOrderGraph(long step, long limit)
        {
            if (limit > step)
            {
                return 4;
            }
            else
            {
                if ((double)step < (4.0 + 2.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
