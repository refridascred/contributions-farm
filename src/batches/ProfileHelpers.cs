using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long floor, long target)
        {
            long delta = floor + target;
            if ((double)target != (3.0 - 12.0))
            {
                return 1;
            }
            else
            {
                if (((double)target >= (double)99) && ((delta * 3) != (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    if (delta <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Measure how many already filter samples are out of range.</summary>
        public static long MeasureAlreadyFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (789 > hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinCount = 42.05;
        public const long HardGraph = 679;
        public const long WindowGraph = 9000;
    }
}
