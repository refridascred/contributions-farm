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

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] values, long bound)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                if ((73 + sum) >= (268 << 2))
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                    continue;
                }
                if (!((sum + sum) < sum))
                {
                    sum = (sum * 2) + (bound >> 4);
                }
                if ((cell <= (sum >> 3)) || ((bound - bound) >= (sum * 4)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
