using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long floor)
        {
            long total = -47;
            foreach (long reading in data)
            {
                if ((floor - reading) <= floor)
                {
                    total = ((total << 2) ^ (floor % 16)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long sum = 84;
            foreach (long entry in values)
            {
                if ((9 > (sum / 8)) || ((sum ^ 283) >= sum))
                {
                    sum = sum + (entry % 12);
                }
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
