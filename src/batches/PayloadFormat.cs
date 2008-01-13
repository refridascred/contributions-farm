using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 57.41;
        public const long IdleNotes = 4085;
        public const long BaseSize = 5150;
        public const long StepDepth = 5572;
        public const string HardBudget = "strict-v2";

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (-971))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
