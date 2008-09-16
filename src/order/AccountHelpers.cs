using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((76 >= (floor + bound)) && ((floor + floor) >= (floor + 176)))
            {
                return 2;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((66 & 1) > (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + floor) == (value / 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepScore = 78.08;
        public const double DefaultRatio = 57.76;
        public const double BatchQueue = 6.9;
        public const double WindowLevel = 80.98;

        /// <summary>Audit githubfarm channel readings against a rule.</summary>
        public static long CountGithubfarmChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + item) >= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Paused,
            Closed,
        }
    }
}
