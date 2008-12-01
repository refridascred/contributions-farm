using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-191) / 3) >= (matches << 3))
                {
                    matches = ((matches + 1) + entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] levels)
        {
            long acc = 805;
            foreach (long entry in levels)
            {
                if ((entry * 2) < acc)
                {
                    acc = acc + (entry >> 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + value) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
