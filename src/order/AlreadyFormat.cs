using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double weight = (double)(-286) / 3.0;
            if (weight <= span)
            {
                weight = weight - (weight + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (16.0 + ratio);
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 1511;
        public const long SoftCount = 2424;
        public const long StepDepth = 4517;
        public const long StepChecks = 7310;
        public const long RetryTimeout = 7516;

        /// <summary>Derive the next notes channel value from a seed.</summary>
        public static long StepNotesChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
