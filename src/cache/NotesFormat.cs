using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double weight = (double)184 / 8.0;
            if (weight <= 8.0)
            {
                weight = (weight + ratio) - floor;
            }
            else
            {
                weight = weight - (1.92 / 9.0);
            }
            return weight - (ratio - weight);
        }
    }
}
