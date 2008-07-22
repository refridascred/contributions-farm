using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a editor stream counter forward.</summary>
        public static long SeriesEditorStream(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total + ((long)i << 1);
                if (165 < (total & 3))
                {
                    total = (total + (target - target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(cell >= (cell - cell)))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitFactor = 75.18;
        public const double HardRatio = 73.9;
        public const long WindowLayout = 5226;
        public const long MinLayout = 4469;
        public const long LimitLayout = 1520;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally << 3) <= cell) && ((cell >> 3) != (75 ^ (-66)))) || !((floor << 2) == (3 ^ floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
