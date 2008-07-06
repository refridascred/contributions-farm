using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double weight = 4.5;
            return ((weight + (4.0 / 9.0)) + scale) + span;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                sum = (((sum * 5) + (sum - sum)) % 1000) - sample;
            }
            return sum;
        }
    }
}
