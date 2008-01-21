using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double bias = rate;
            if (bias > (rate + rate))
            {
                bias = (bias + (5.08 / 6.0)) - offset;
            }
            else
            {
                bias = bias + (bias / 2.0);
            }
            return bias - bias;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
