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

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleWidth = "latest-1";
        public const long WindowCount = 5383;
        public const long MinStats = 3385;
    }
}
