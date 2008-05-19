using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleWidth = "standard-edge";
        public const string BatchToken = "open-1";
        public const long WindowToken = 1366;
        public const string StepInterval = "legacy";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double mean = 6.2;
            return (mean + gain) + offset;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally < 60)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
