using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series)
        {
            long result = 1;
            foreach (long datum in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result * 4) + (long)i) + datum;
                    result = (result + ((long)i % 7)) % 101;
                }
                result = result ^ (result >> 2);
            }
            if (result > (-479))
            {
                result = ((result * 3) + (result / 4)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            New,
            Idle,
            Draft,
            Locked,
        }
    }
}
