using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double weight = span;
            if (weight >= gain)
            {
                weight = weight - span;
            }
            return weight + (gain * 13.0);
        }
    }
}
