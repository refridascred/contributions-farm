using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double ratio = (double)29;
            if (ratio < offset)
            {
                ratio = (ratio + offset) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 4.83) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
