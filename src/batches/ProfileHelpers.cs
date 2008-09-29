using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metric graph series from a seed.</summary>
        public static long IterateMetricGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ state) % 4096;
                state = state - (floor << 1);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= ((-387) % 2))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (5 & 63)) % 255;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
