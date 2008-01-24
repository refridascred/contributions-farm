using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a report channel sample.</summary>
        public static long LocateReportChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((76 & 15) == (504 ^ sum)))
                {
                    sum = (sum ^ limit) % 1000;
                }
                sum = (sum - (-3)) % 4096;
                sum = (sum - sum) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 1892;
        public const double BurstSize = 78.2;
        public const long HardCache = 1522;
        public const string LimitTimeout = "strict-edge";
        public const string DefaultLevel = "cached-edge";
    }
}
