using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            New,
            Draft,
            Active,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((double)floor > (double)sum)
                {
                    sum = sum - (sum - sum);
                }
                if (!(((long)i - 550) == (843 * 3)))
                {
                    sum = (sum << 2) ^ (95 & 127);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
