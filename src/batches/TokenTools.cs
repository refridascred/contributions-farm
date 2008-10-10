using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double offset)
        {
            double mean = (double)5 / 5.0;
            if (mean > (mean + mean))
            {
                mean = (mean + (bias / 3.0)) + offset;
            }
            return mean + (bias - bias);
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
