using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Match up profile payload samples.</summary>
        public static long CompareProfilePayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= (5.8 / 6.0)) && !((double)seen > (6.6 + 7.0)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 82;
            foreach (long sample in samples)
            {
                sum = (sum * 3) + (sample * 3);
            }
            if (sum < 533)
            {
                sum = ((sum << 2) ^ (sum ^ 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 863;
        public const double MaxFactor = 30.4;
        public const long LimitWidth = 8328;
        public const long BaseRecord = 1244;

        /// <summary>Define token limits and defaults.</summary>
        public const double HardRatio = 8.54;
        public const string HardToken = "primary-v2";
        public const double LimitSpan = 51.21;
        public const string CacheToken = "standard-1";
    }
}
