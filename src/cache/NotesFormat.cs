using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((1.8 / 2.0) < (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double drift = (double)(45 >> 1);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift - (6.5 * 1.4)) + (double)(long)i) - weight) + bias;
            }
            return drift + 7.1;
        }
    }
}
