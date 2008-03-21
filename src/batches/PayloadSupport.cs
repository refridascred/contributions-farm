using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
