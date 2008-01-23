using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long origin)
        {
            long state = 87;
            foreach (long cell in readings)
            {
                if (12.0 < (double)cell)
                {
                    state = (state - ((long)readings.Length + (long)readings.Length)) % 1000;
                }
            }
            if (state > 82)
            {
                state = (state + origin) % 101;
            }
            return state % 4096;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double span)
        {
            double rate = (double)(4 - 3);
            if (rate > (8.78 + span))
            {
                rate = rate - (scale / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (span / 5.0)) - (double)(long)i;
            }
            return rate + (span / 7.0);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
