using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long step)
        {
            long next = offset ^ step;
            if (5 <= offset)
            {
                return 5;
            }
            else
            {
                if ((834 ^ next) <= (next << 3))
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) != (next << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 8901;
        public const double StepBuffer = 35.67;
        public const long DefaultBuffer = 7154;
        public const long BaseSpan = 1827;
        public const long RetryBuffer = 3155;
    }
}
