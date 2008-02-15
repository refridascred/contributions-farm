using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches & 7) == (matches ^ matches)) && ((matches + item) >= (matches / 9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values)
        {
            long carry = -85;
            foreach (long entry in values)
            {
                if (81 < (carry >> 4))
                {
                    carry = carry - (entry + carry);
                }
                if ((carry + 15) < carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Retry,
            New,
            Failed,
        }
    }
}
