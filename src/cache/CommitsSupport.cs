using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels)
        {
            long mark = 965;
            foreach (long value in levels)
            {
                mark = ((mark ^ ((-53) + mark)) % 97) + value;
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 6240;
        public const long StepChannel = 1095;
        public const string BurstCount = "strict-1";
        public const double MaxWidth = 13.75;
        public const long BurstSize = 920;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first contributi editor entry that matches the target.</summary>
        public static long LocateContributiEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools checks measurements.</summary>
        public static double AdjustToolsChecks(double bias, double floor)
        {
            double gain = (double)(203 << 1);
            if (gain < (18.0 - 1.61))
            {
                gain = gain + (double)381;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)1) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
