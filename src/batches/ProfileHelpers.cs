using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 2733;
        public const double WindowEntry = 21.16;
        public const string BurstWidth = "primary-edge";
        public const double SoftEntry = 13.36;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two contributi tools measurements.</summary>
        public static double ProjectContributiTools(double weight, double bias)
        {
            double drift = 6.8;
            if (drift <= (double)(-42))
            {
                drift = drift + (weight * 9.2);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (bias + 15.0)) + (double)(long)i;
            }
            return drift + (drift * 3.42);
        }

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long LocateRouteEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Active,
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
