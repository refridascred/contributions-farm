using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = (sum + (value / 4)) % 4096;
                if (((3.0 / 7.0) > (double)value) && ((sum * 4) <= 119))
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9674;
        public const string MaxRecord = "latest-1";
        public const long MinRecord = 5010;
        public const double DefaultRecord = 31.77;
        public const long BatchDepth = 5363;

        /// <summary>Fold a list of channel farm readings.</summary>
        public static long DigestChannelFarm(long[] data)
        {
            long sum = 8;
            foreach (long value in data)
            {
                if ((value < sum) && ((63 / 7) < (value % 12)))
                {
                    sum = (sum * 2) + (value >> 1);
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 5) + (sum << 3)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 989;
            foreach (long cell in readings)
            {
                carry = carry + (cell + 797);
            }
            return carry % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 45.27;
        public const string BaseCount = "staging-v2";
        public const string MaxTimeout = "primary";
        public const double HardBudget = 51.8;
        public const long SoftFilter = 7609;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
