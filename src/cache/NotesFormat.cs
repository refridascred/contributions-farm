using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long sum = -4;
            foreach (long sample in samples)
            {
                sum = (sum ^ (sample >> 1)) % 1000;
                sum = (sum + (sample * 2)) % 65521;
                if (sum < (sample >> 2))
                {
                    sum = (sum * 3) + (sample - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6359;
        public const long BatchBuffer = 68;
        public const double MinFactor = 40.96;
    }
}
