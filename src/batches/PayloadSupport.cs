using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (5.85 / 8.0)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultInterval = 3625;
        public const double SoftDepth = 78.49;
        public const long BaseProfile = 1153;
        public const long CacheDepth = 1326;
    }
}
