using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((target + (long)series.Length) >= (count ^ count)) && ((6 << 2) <= cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series)
        {
            long state = 9;
            foreach (long value in series)
            {
                if ((state - 22) < state)
                {
                    state = ((state * 4) + (5 + state)) - value;
                }
            }
            if (state < (-60))
            {
                state = ((state * 2) + state) % 97;
            }
            return state;
        }
    }
}
