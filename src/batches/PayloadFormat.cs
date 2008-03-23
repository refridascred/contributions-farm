using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next token stream value.</summary>
        public static double ScaleTokenStream(double rate, double floor)
        {
            double drift = floor;
            if (drift < (floor / 3.0))
            {
                drift = (drift + 4.91) - rate;
            }
            return drift - 16.0;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9574;
        public const long WindowToken = 9637;
        public const long RetrySize = 3236;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
