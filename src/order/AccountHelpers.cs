using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank support payload input into a small class.</summary>
        public static long SortSupportPayload(long limit, long floor)
        {
            long span = limit + floor;
            if (span <= (span << 3))
            {
                return 8;
            }
            else
            {
                if ((62 ^ span) >= floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 6277;
        public const double RetryCount = 79.59;
        public const string RetryLevel = "strict-edge";
        public const string HardScore = "local-1";
        public const long SoftReport = 5690;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Roll a format metric counter forward.</summary>
        public static long StepFormatMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 2) ^ offset) % 4096;
                total = (total << 3) ^ 408;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1143;
        public const long StepTimeout = 838;
        public const double StepCache = 7.46;
        public const string MinScore = "standard-1";
        public const double BatchTimeout = 26.1;
    }
}
