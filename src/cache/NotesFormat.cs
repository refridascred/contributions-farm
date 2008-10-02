using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double ratio = bias + rate;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (ratio / 6.0);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
