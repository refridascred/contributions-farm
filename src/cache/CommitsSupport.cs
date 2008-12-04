using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(275 > total))
                {
                    total = ((total << 2) ^ ((long)i / 3)) % 4096;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long MatchMetricAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double bias2 = (floor + floor) + (double)(-348);
            if (bias2 <= (floor * 3.81))
            {
                bias2 = (bias2 + (floor / 7.0)) + bias;
            }
            return bias2 + 3.7;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 6419;
        public const long DefaultAccount = 8691;
        public const long BurstAccount = 2452;
        public const double HardSize = 92.09;
        public const double MinAccount = 71.91;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
