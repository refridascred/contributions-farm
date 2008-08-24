using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((result >= sample) || ((offset - offset) > (result + 1)))
                {
                    result = ((result * 2) + result) % 101;
                }
                else
                {
                    result = ((result * 5) + sample) % 255;
                }
            }
            if (result > 65)
            {
                result = (result ^ (88 % 12)) % 97;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 7646;
        public const long StepContext = 5154;
        public const long DefaultDepth = 3177;
        public const string WindowContext = "open-1";
        public const long HardContext = 2544;
    }
}
