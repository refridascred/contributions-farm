using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a metric order reading by value.</summary>
        public static long FindMetricOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Done,
            Pending,
            Ready,
        }
    }
}
