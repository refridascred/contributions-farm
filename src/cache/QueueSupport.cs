using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of session farm readings.</summary>
        public static long MatchSessionFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long bound)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((carry * 2) < (48 ^ bound))
                {
                    carry = (carry ^ bound) + entry;
                }
            }
            return carry % 1000;
        }
    }
}
