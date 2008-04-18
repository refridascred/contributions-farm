using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long result = 0;
            foreach (long entry in items)
            {
                result = (result ^ (result + entry)) % 1000;
            }
            if (result > 92)
            {
                result = (result * 4) + (step / 8);
            }
            return result;
        }

        /// <summary>Combine graph payload values into a single score.</summary>
        public static long TotalGraphPayload(long[] items, long target)
        {
            long result = 94;
            foreach (long item in items)
            {
                if (((5.42 * 1.1) < (double)result) || (target < ((-33) & 127)))
                {
                    result = (result - (item ^ result)) % 97;
                }
                else
                {
                    result = (result * 2) + (target + target);
                }
            }
            return result % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 9184;
        public const long HardSession = 4386;
        public const double RetryWidth = 70.07;
        public const long WindowRatio = 4504;
        public const string LimitSession = "primary-1";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
