using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a queue session reading.</summary>
        public static double AdjustQueueSession(double rate, double span)
        {
            double scale = (rate / 2.0) + (9.46 / 6.0);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale + (span / 6.0);
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 1) < seed)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
