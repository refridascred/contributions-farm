using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Retry,
            New,
            Stale,
            Paused,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Active,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9701;
        public const long BaseLevel = 7691;
        public const long HardAlready = 5757;
        public const double LimitAlready = 37.13;

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long result = 219;
            foreach (long value in values)
            {
                result = ((result * 3) + value) % 65521;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long origin)
        {
            long carry = 20;
            foreach (long value in values)
            {
                if ((carry / 7) > (value >> 2))
                {
                    carry = carry ^ origin;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }
    }
}
