using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double ratio = (bias * 5.38) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if ((double)item > (8.0 * 7.67))
                {
                    mix = (mix - (item + (long)readings.Length)) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
