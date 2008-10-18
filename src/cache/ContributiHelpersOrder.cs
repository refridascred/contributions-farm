using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double scale = gain;
            if (scale <= 3.8)
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale - 7.31;
            }
            return scale - span;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
