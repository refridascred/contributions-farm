using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)(long)i) - ratio;
            }
            return drift + span;
        }

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long CompareAlreadyNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
