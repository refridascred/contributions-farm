using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double rate, double span)
        {
            double gain = span;
            if (gain > (span * 4.63))
            {
                gain = gain - rate;
            }
            return gain + (gain - 3.9);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }
    }
}
