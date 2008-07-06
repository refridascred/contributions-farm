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

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long bound)
        {
            long carry = 15;
            foreach (long value in data)
            {
                if (value < (value / 6))
                {
                    carry = (carry + (value ^ 5)) % 4096;
                }
                else
                {
                    carry = (carry + (bound - bound)) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
