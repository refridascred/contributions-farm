using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a cluster profile figure with a bias.</summary>
        public static double BlendClusterProfile(double ratio, double span)
        {
            double bias = ratio;
            if (bias > ratio)
            {
                bias = (bias - (double)6) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (ratio - ratio)) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Closed,
            Active,
            New,
            Ready,
        }

        /// <summary>Iterate the contributi profile series from a seed.</summary>
        public static long SeriesContributiProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (mark % 100)) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
