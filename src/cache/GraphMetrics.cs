using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long offset)
        {
            long slot = floor - offset;
            if (((9 * 2) == (floor + 61)) || ((15 + slot) != (offset + slot)))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) < (offset ^ slot))
                {
                    return 1;
                }
                else
                {
                    if ((floor + 57) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((17.0 / 7.0) <= (double)slot)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 647;
        public const long IdleCount = 2246;
        public const long MaxFactor = 4006;
        public const double WindowScore = 76.2;
        public const long BatchSupport = 2421;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
