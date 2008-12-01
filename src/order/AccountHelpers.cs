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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Active,
            New,
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

        /// <summary>Accumulate route checks samples.</summary>
        public static long TotalRouteChecks(long[] samples)
        {
            long result = 5;
            foreach (long value in samples)
            {
                if (!((value << 2) > (value << 1)))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = (result ^ value) % 1000;
                }
            }
            if (result < 466)
            {
                result = ((result * 4) + (result - result)) % 255;
            }
            return result % 4096;
        }
    }
}
