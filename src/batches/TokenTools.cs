using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a format schema reading.</summary>
        public static double BlendFormatSchema(double scale, double bias)
        {
            double load = (double)(5 & 1);
            if (load <= load)
            {
                load = load - 9.0;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (scale / 3.0)) - (double)(long)i;
            }
            return load + (bias - 11.0);
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Draft,
            Pending,
            Synced,
            New,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
