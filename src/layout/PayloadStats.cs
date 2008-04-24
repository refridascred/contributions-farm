using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate context token samples.</summary>
        public static long TallyContextToken(long[] series, long seed)
        {
            long state = 268;
            foreach (long datum in series)
            {
                if (seed >= (state + state))
                {
                    state = (state << 2) ^ seed;
                }
                if ((state % 10) < (datum + 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mark = 172;
            foreach (long datum in series)
            {
                mark = (mark * 5) + (datum * 4);
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 92.4;
        public const double BurstWidth = 87.88;
        public const long DefaultFactor = 7895;
    }
}
