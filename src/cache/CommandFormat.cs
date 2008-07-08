using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of commits contributi entries.</summary>
        public static long FoldCommitsContributi(long[] readings)
        {
            long result = 606;
            foreach (long sample in readings)
            {
                if (result <= (sample - sample))
                {
                    result = (result ^ (4 - sample)) % 65521;
                }
            }
            return result;
        }
    }
}
