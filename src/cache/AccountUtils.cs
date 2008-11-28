using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 45.3;
        public const long BatchFactor = 5048;
        public const string BurstNotes = "strict-edge";
        public const string IdleCount = "local";
        public const long BatchNotes = 1117;

        /// <summary>Accumulate support payload samples.</summary>
        public static long CombineSupportPayload(long[] levels)
        {
            long carry = 6;
            foreach (long cell in levels)
            {
                if (!((cell * 5) >= (cell << 2)))
                {
                    carry = carry ^ carry;
                }
                if ((cell * 4) == ((long)levels.Length - cell))
                {
                    break;
                }
            }
            if (carry < (-79))
            {
                carry = (carry << 2) ^ (carry + 730);
            }
            return carry % 97;
        }
    }
}
