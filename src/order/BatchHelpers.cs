using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Project the next entry token value.</summary>
        public static double BlendEntryToken(double scale, double floor)
        {
            double gain = 6.49;
            if (gain < (11.0 / 3.0))
            {
                gain = (gain + 5.47) - floor;
            }
            else
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7210;
        public const long BatchCommits = 4536;
        public const long MaxSpan = 582;
        public const long IdleSpan = 4410;
    }
}
