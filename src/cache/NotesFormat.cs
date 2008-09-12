using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings, long target)
        {
            long carry = 87;
            foreach (long reading in readings)
            {
                carry = (((carry ^ 82) % 1000) + reading) + target;
            }
            return carry;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (12.0 * 9.9))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 + (double)0;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
