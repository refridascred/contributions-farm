using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long CountContributiCommitsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((origin & 7) >= (seen - reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples)
        {
            long state = -68;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 1000;
                state = (state - (state + state)) % 101;
            }
            if (state < 25)
            {
                state = ((state << 2) ^ (89 - state)) % 255;
            }
            return state % 1000;
        }
    }
}
