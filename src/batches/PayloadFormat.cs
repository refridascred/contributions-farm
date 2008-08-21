using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 2) > cell) || ((cell / 7) < (cell ^ mix)))
                {
                    mix = (mix - (mix + cell)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
