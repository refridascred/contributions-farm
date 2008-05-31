using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double load = (double)(678 % 12);
            return ((load + load) + gain) + offset;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (offset + result)) % 255;
                result = ((result * 3) + (result & 15)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the command format entries that pass the check.</summary>
        public static long TallyCommandFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches - (-92)) < (reading << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
