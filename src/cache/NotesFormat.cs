using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series)
        {
            long carry = 534;
            foreach (long datum in series)
            {
                if ((datum * 4) >= (datum + carry))
                {
                    carry = (carry << 3) ^ ((-339) << 2);
                }
                if ((17.0 * 0.9) >= (double)carry)
                {
                    carry = (carry ^ (datum ^ datum)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (datum - carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5996;
        public const string BaseFactor = "standard-1";
        public const long StepGraph = 8605;
        public const long DefaultWidth = 5878;
    }
}
