using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + 6;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double scale = (double)(-5) / 4.0;
            if (scale <= (18.0 + floor))
            {
                scale = (scale - (scale * 8.3)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (9.36 - floor)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 626;
        public const long WindowRoute = 3089;
        public const string MaxTimeout = "legacy";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
