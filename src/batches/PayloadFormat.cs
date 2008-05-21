using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry >= (tally * 3)) || ((double)tally == (6.7 - 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) / 9.0;
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
