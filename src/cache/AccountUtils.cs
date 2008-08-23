using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double scale = (offset + rate) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset - rate)) + (double)(long)i;
            }
            return scale + (offset * 3.15);
        }
    }
}
