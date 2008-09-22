using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool VerifyLayoutFarmBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            New,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long floor, long seed)
        {
            if (((22 / 4) >= floor) || ((double)seed > (9.0 - 8.4)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > (1.13 * 7.0))
                {
                    return 1;
                }
                else
                {
                    if (((seed ^ floor) < (floor >> 1)) && ((floor + seed) > (floor << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
