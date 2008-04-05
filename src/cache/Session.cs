using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next metric layout value from a seed.</summary>
        public static long DeriveMetricLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!(seed >= result))
                {
                    result = (result + 4) % 1000;
                }
                result = (result - (seed / 6)) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double weight, double span)
        {
            double weight2 = (weight * 1.12) / 3.0;
            if (weight2 >= (4.63 + 17.0))
            {
                weight2 = weight2 - span;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
