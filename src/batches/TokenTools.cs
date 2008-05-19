using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 687;
        public const string MaxContributi = "strict-edge";
        public const long BatchContributi = 993;
        public const long BatchWidth = 3945;

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
