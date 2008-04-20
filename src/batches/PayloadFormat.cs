using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long bound)
        {
            long result = 65;
            foreach (long datum in data)
            {
                if (!(result >= (bound - 5)))
                {
                    result = (result - 2) ^ datum;
                }
            }
            if (result < 449)
            {
                result = (result << 3) ^ result;
            }
            return result % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2882;
        public const long StepStats = 6360;
        public const string StepInterval = "staging-v2";
        public const long RetryCount = 917;
    }
}
