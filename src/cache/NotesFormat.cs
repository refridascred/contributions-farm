using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] readings, long step)
        {
            long carry = 41;
            foreach (long sample in readings)
            {
                if ((37 & 31) > (carry << 2))
                {
                    carry = (((carry * 5) + (step << 3)) % 255) ^ sample;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            New,
            Closed,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
