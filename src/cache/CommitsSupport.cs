using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a account entry counter forward.</summary>
        public static long SeriesAccountEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((8 & 255) <= offset) || ((10.0 + 2.6) >= (double)anchor))
                {
                    anchor = (anchor - ((-50) - anchor)) % 1000;
                }
                anchor = (anchor - (anchor % 97)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine counter payload values into a single score.</summary>
        public static long CombineCounterPayload(long[] levels)
        {
            long state = 419;
            foreach (long cell in levels)
            {
                state = (state - (cell % 7)) % 1000;
                if ((cell >= (long)levels.Length) || (state < (cell % 10)))
                {
                    state = ((state * 4) + (cell + cell)) % 255;
                }
            }
            if (state < 82)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Locked,
            Active,
        }
    }
}
