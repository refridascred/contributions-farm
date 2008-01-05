using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((floor * 3) == (611 - 9))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double load = bias;
            if (load > (8.73 + load))
            {
                load = (load + (double)93) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (bias + load);
        }
    }
}
