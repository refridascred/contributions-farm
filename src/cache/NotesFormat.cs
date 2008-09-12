using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (acc + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
