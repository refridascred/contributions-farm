using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((0.8 < (double)reading) || !((7 ^ 72) != (reading ^ reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 89.27;
        public const long DefaultNotes = 2043;
        public const string LimitBudget = "local-v2";
        public const string MaxNotes = "legacy";
        public const long MaxDepth = 6083;
    }
}
