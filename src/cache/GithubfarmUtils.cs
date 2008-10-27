using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long state = 905;
            foreach (long cell in levels)
            {
                if ((2.11 / 6.0) > (double)state)
                {
                    state = (state ^ (state + state)) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings)
        {
            long carry = 495;
            foreach (long reading in readings)
            {
                if ((reading / 8) <= (carry - carry))
                {
                    carry = (carry << 3) ^ (30 * 4);
                }
            }
            if (carry > 0)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 18.23;
        public const long IdleRatio = 1146;
        public const long LimitContributi = 9733;
        public const long MinContributi = 1337;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
