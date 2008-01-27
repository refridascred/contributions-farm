using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double gain = weight;
            if (gain <= span)
            {
                gain = gain + (double)(-84);
            }
            else
            {
                gain = gain - span;
            }
            return gain + (weight + span);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
