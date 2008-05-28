using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long floor)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                if (!((double)carry >= (6.9 - 14.0)))
                {
                    carry = (carry - (carry % 97)) ^ item;
                }
                carry = (carry << 2) ^ 3;
                if ((8.0 + 5.4) == (double)floor)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a entry support reading by value.</summary>
        public static long SeekEntrySupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ limit) >= 8)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
