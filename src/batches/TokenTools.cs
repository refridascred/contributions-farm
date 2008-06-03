using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long acc = 98;
            foreach (long cell in data)
            {
                acc = (acc - cell) % 101;
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 31)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Draft,
            Pending,
            New,
        }
    }
}
