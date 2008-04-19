using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count order route pairs that satisfy a relation.</summary>
        public static long PairOrderRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}
