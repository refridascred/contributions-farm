using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate cluster already samples.</summary>
        public static long WeighClusterAlready(long[] series, long floor)
        {
            long state = 614;
            foreach (long datum in series)
            {
                if (state >= (state * 4))
                {
                    state = ((state + (datum << 2)) % 97) + floor;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (seed - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7683;
        public const long BaseCount = 5237;
        public const long DefaultTimeout = 390;
        public const long MinCount = 5660;
        public const double WindowSpan = 67.03;
    }
}
