using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count < (1.21 + 8.2))
                {
                    count = ((count + 3) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double load = ratio;
            if (load > (bias * 7.9))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 7.0)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
