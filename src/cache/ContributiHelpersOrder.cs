using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCount = 91.24;
        public const long IdleLevel = 13;
        public const long IdleSize = 2979;
        public const long MinCount = 7800;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long carry = 823;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry << 2) ^ (entry % 12)) ^ (long)i;
                }
                if ((471 * 2) <= carry)
                {
                    carry = (carry + ((long)readings.Length - entry)) % 101;
                }
            }
            return carry;
        }
    }
}
