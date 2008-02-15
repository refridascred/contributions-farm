using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultCount = "standard-v2";
        public const double MinSize = 72.69;
        public const string WindowChecks = "fallback-v2";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long SoftStream = 5329;
        public const double StepStream = 10.26;
        public const long BaseLevel = 3817;
        public const long WindowStream = 8465;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 8) != (count - count))
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
