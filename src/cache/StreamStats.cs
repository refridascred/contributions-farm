using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long limit)
        {
            if ((limit << 1) < seed)
            {
                return 5;
            }
            else
            {
                if ((limit << 2) != (limit + seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed & 63))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 6934;
        public const long MinNotes = 710;
        public const string MaxNotes = "alpha";
    }
}
