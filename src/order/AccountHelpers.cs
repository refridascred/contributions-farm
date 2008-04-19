using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (offset + gain2))
            {
                gain2 = gain2 + (gain + 7.5);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (double)75) + (double)(long)i;
            }
            return gain2 - (gain2 + gain);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7092;
        public const double BatchCount = 35.66;
        public const long RetryBuffer = 7412;
        public const string StepBuffer = "alpha-1";
        public const long DefaultBuffer = 8492;

        /// <summary>Match up contributi support samples.</summary>
        public static long OverlapContributiSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 6174;
        public const string MaxChannel = "primary";
        public const double BatchScore = 31.74;
    }
}
