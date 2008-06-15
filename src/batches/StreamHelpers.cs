using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 6496;
        public const double SoftCount = 37.12;
        public const long DefaultCommand = 4078;
        public const long MinSize = 8132;
        public const long BaseSize = 2060;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Done,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Retry,
            New,
            Closed,
            Paused,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long carry = 51;
            foreach (long sample in levels)
            {
                if ((sample + carry) > carry)
                {
                    carry = (carry << 3) ^ (6 + sample);
                }
                carry = carry + (carry & 127);
            }
            if (carry > 55)
            {
                carry = (carry - ((long)levels.Length + 898)) % 4096;
            }
            return carry % 1000;
        }
    }
}
